using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExamSubject5
{
    public partial class MainForm : Form
    {
        private List<Specialty> specialties;
        private List<Doctor> doctors;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject5\\ExamSubject5\\database.db";
        public MainForm()
        {
            InitializeComponent();
            specialties = LoadSpecialties("C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject5\\ExamSubject5\\Specialties.txt");
            doctors = new List<Doctor>();
            LoadDoctorsDB();
            listViewDoctors.View = View.Details;
            listViewDoctors.FullRowSelect = true;
            PopulateListView();
        }

        private List<Specialty> LoadSpecialties(string filePath)
        {
            List<Specialty> specialties = new List<Specialty>();

            if(File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach(string line in lines)
                {
                    string[] parts = line.Split(',');

                    if(parts.Length == 2)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];

                        specialties.Add(new Specialty(id, name));
                    }
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }

            return specialties;
        }

        private void PopulateListView()
        {
            listViewDoctors.Items.Clear();

            foreach(var doctor in doctors)
            {
                ListViewItem lvi = new ListViewItem(doctor.Id.ToString());
                lvi.SubItems.Add(doctor.Name);
                lvi.SubItems.Add(doctor.BirthDate.ToShortDateString());
                lvi.SubItems.Add(doctor.Wage.ToString());
                lvi.SubItems.Add(specialties.First(s => s.Id == doctor.SpecialtyId).Name);
                lvi.Tag = doctor;

                listViewDoctors.Items.Add(lvi);
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            var form = new AddEditDoctor(specialties);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var doctor = form.Doctor;
                doctors.Add(doctor);
                PopulateListView();
                AddDoctorDB(doctor);
            }
        }

        private void listViewDoctors_DoubleClick(object sender, EventArgs e)
        {
            if (listViewDoctors.SelectedItems.Count > 0)
            {
                var item = listViewDoctors.SelectedItems[0];
                var doctor = (Doctor)item.Tag;

                var form = new AddEditDoctor(specialties);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    doctors.Remove(doctor);
                    doctor = form.Doctor;
                    doctors.Add(doctor);
                    PopulateListView();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listViewDoctors.SelectedItems.Count > 0)
            {
                var item = listViewDoctors.SelectedItems[0];
                var doctor = (Doctor)item.Tag;

                doctors.Remove(doctor);
                PopulateListView();
            }
        }

        private void LoadDoctorsDB()
        {
            string query = "SELECT * FROM Doctors";

            using(SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string name = (string)reader["Name"];
                        DateTime birthDate = DateTime.Parse((string)reader["BirthDate"]);
                        double wage = (double)reader["Wage"];
                        long specialtyId = (long)reader["SpecialtyId"];

                        Doctor doctor = new Doctor((int)id, name, birthDate, wage, (int)specialtyId);
                        doctors.Add(doctor);
                    }
                }
            }
        }

        private void AddDoctorDB(Doctor doctor)
        {
            string query = "INSERT INTO Doctors (Id, Name, BirthDate, Wage, SpecialtyId) "
                + "VALUES (@id, @name, @birthDate, @wage, @specialtyId)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", doctor.Id);
                command.Parameters.AddWithValue("@name", doctor.Name);
                command.Parameters.AddWithValue("@birthDate", doctor.BirthDate);
                command.Parameters.AddWithValue("@wage", doctor.Wage);
                command.Parameters.AddWithValue("@specialtyId", doctor.SpecialtyId);

                command.ExecuteNonQuery();
            }
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML File | *.xml";
                saveFileDialog.Title = "Save Doctors List";

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToXML(saveFileDialog.FileName);
                }
            }
        }

        private void ExportToXML(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Doctor>));
            using (StreamWriter  sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, doctors);
            }
            MessageBox.Show("Export successful.");
        }

        private void sortByNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doctors.Sort(new DoctorComparerName());
            PopulateListView();
        }

        private void sortByBirthDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doctors.Sort(new DoctorComparerBirthDate());
            PopulateListView();
        }
    }
}
