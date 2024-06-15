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

namespace ExamSubject6
{
    public partial class MainForm : Form
    {
        private List<Room> rooms;
        private List<Reservation> reservations;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject6\\ExamSubject6\\database.db";
        public MainForm()
        {
            InitializeComponent();
            rooms = LoadRooms("C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject6\\ExamSubject6\\Rooms.txt");
            reservations = new List<Reservation>();

            LoadReservationsDB();
            PopulateListView();
        }

        private List<Room> LoadRooms(string filePath)
        {
            List<Room> rooms = new List<Room>();

            if(File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach(string line in lines)
                {
                    string[] parts = line.Split(',');
                    if(parts.Length == 3)
                    {
                        int id = int.Parse(parts[0]);
                        int number = int.Parse(parts[1]);
                        int beds = int.Parse(parts[2]);

                        Room room = new Room(id, number, beds);
                        rooms.Add(room);
                    }
                }
            }
            else
            {
                MessageBox.Show("The file does not exist");
            }
            return rooms;
        }

        private void PopulateListView()
        {
            listView1.Items.Clear();

            foreach(var reservation in reservations)
            {
                ListViewItem lvi = new ListViewItem(reservation.Id.ToString());
                lvi.SubItems.Add(reservation.CheckInDate.ToShortDateString());
                lvi.SubItems.Add(reservation.CheckOutDate.ToShortDateString());
                lvi.SubItems.Add(reservation.Persons.ToString());
                lvi.SubItems.Add(rooms.First(r => r.Id == reservation.RoomId).Number.ToString());
                lvi.Tag = reservation;

                listView1.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditReservationForm(rooms);

            if(form.ShowDialog() == DialogResult.OK)
            {
                var reservation = form.Reservation;
                reservations.Add(reservation);
                PopulateListView();
                AddReservationDB(reservation);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                var reservation = (Reservation)item.Tag;

                var form = new AddEditReservationForm(rooms);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    reservations.Remove(reservation);
                    reservation = form.Reservation;
                    reservations.Add(reservation);
                    PopulateListView();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                var reservation = (Reservation)item.Tag;
                reservations.Remove(reservation);
                PopulateListView();
            }
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML File | *.xml";
                saveFileDialog.Title = "Save Reservations List";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportXML(saveFileDialog.FileName);
                }
            }
        }

        private void ExportXML(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Reservation>));
            using(StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, reservations);
            }
            MessageBox.Show("Export successful");
        }

        private void LoadReservationsDB()
        {
            string query = "SELECT * FROM Reservations";

            using(SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        DateTime checkIn = DateTime.Parse((string)reader["CheckIn"]);
                        DateTime checkOut = DateTime.Parse((string)reader["CheckOut"]);
                        long persons = (long)reader["Persons"];
                        long roomId = (long)reader["RoomId"];

                        Reservation reservation = new Reservation((int)id, checkIn, checkOut, (int)persons, (int)roomId);
                        reservations.Add(reservation);
                    }
                }
            }
        }

        private void AddReservationDB(Reservation reservation)
        {
            string query = "INSERT INTO Reservations (Id, CheckIn, CheckOut, Persons, RoomId) "
                + "VALUES (@id, @checkIn, @checkOut, @persons, @roomId)";

            using(SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", reservation.Id);
                command.Parameters.AddWithValue("@checkIn", reservation.CheckInDate);
                command.Parameters.AddWithValue("@checkOut", reservation.CheckOutDate);
                command.Parameters.AddWithValue("@persons", reservation.Persons);
                command.Parameters.AddWithValue("@roomId", reservation.RoomId);

                command.ExecuteNonQuery();
            }
        }

        private void cbComparer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComparer.SelectedItem.ToString() == "Persons")
            {
                reservations.Sort(new ReservationComparerPersons());
            }
            else if (cbComparer.SelectedItem.ToString() == "CheckInDate")
            {
                reservations.Sort(new ReservationComparerCheckIn());
            }
            PopulateListView();
        }
    }
}
