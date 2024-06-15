using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSubject5
{
    public partial class MainForm : Form
    {
        private List<Specialty> specialties;
        private List<Doctor> doctors;
        public MainForm()
        {
            InitializeComponent();
            specialties = LoadSpecialties("C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject5\\ExamSubject5\\Specialties.txt");
            doctors = new List<Doctor>();
            listViewDoctors.View = View.Details;
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

        private void PopulateListView(Doctor doctor)
        {
            ListViewItem lvi = new ListViewItem(doctor.Id.ToString());
            lvi.SubItems.Add(doctor.Name);
            lvi.SubItems.Add(doctor.BirthDate.ToShortDateString());
            lvi.SubItems.Add(doctor.Wage.ToString());
            lvi.SubItems.Add(specialties.First(s => s.Id == doctor.SpecialtyId).Name);
            lvi.Tag = doctor;

            listViewDoctors.Items.Add(lvi);
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            var form = new AddEditDoctor(specialties);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var doctor = form.Doctor;
                doctors.Add(doctor);
                PopulateListView(doctor);
            }
        }
    }
}
