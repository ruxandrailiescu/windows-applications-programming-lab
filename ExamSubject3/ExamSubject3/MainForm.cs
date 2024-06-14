using ExamSubject3.Entities;
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

namespace ExamSubject3
{
    public partial class MainForm : Form
    {
        private List<Participant> participants;
        private List<string> concertArray;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject3\\ExamSubject3\\database.db";
        public MainForm()
        {
            InitializeComponent();
            participants = new List<Participant>();
            concertArray = new List<string>
            {
                "Coldplay",
                "Saga Festival",
                "Neversea Festival",
                "Keinemusik",
                "Kings of Leon"
            };
            LoadParticipantsDB();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridViewParticipants.Rows.Clear();

            participants.Sort();
            foreach (var participant in participants)
            {
                string concerts = string.Join(",", participant.Concerts);

                int indexRow = dataGridViewParticipants.Rows.Add(
                    participant.Id.ToString(),
                    participant.Name,
                    participant.Email,
                    participant.BirthDate.ToString(),
                    concerts);
                dataGridViewParticipants.Rows[indexRow].Tag = participant;
            }
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            var form = new AddEditParticipant(concertArray);

            if (form.ShowDialog() == DialogResult.OK)
            {
                Participant participant = form.Participant;
                participants.Add(participant);
                PopulateDataGridView();
                AddParticipantDB(participant);
            }
        }

        private void dataGridViewParticipants_DoubleClick(object sender, EventArgs e)
        {
            // Edit/Modify
            if (dataGridViewParticipants.SelectedRows.Count > 0)
            {
                var item = dataGridViewParticipants.SelectedRows[0];
                var participant = (Participant)item.Tag;
                var form = new AddEditParticipant(concertArray, participant);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    participants.Remove(participant);
                    participant = form.Participant;
                    participants.Add(participant);
                    PopulateDataGridView();
                    UpdateParticipantDB(participant);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete
            if (dataGridViewParticipants.SelectedRows.Count > 0)
            {
                var item = dataGridViewParticipants.SelectedRows[0];
                var participant = (Participant)item.Tag;
                participants.Remove(participant);
                PopulateDataGridView();
                DeleteParticipantDB(participant);
            }
        }

        private void btnCalcPart_Click(object sender, EventArgs e)
        {
            int totalParticipants = 0;

            foreach (var participant in participants)
            {
                totalParticipants += (int)participant;
            }

            tbTotalParticipants.Text = totalParticipants.ToString();
        }

        private void LoadParticipantsDB()
        {
            const string query = "SELECT * FROM Participants";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string name = (string)reader["Name"];
                        string email = (string)reader["Email"];
                        DateTime birthDate = DateTime.Parse((string)reader["BirthDate"]);
                        string list = (string)reader["Concerts"];

                        List<string> concerts = new List<string>();
                        string[] parts = list.Split(',');
                        foreach (string part in parts)
                        {
                            concerts.Add(part);
                        }

                        Participant participant = new Participant((int)id, name, email, birthDate, concerts);
                        participants.Add(participant);
                        participants.Sort();
                    }
                }
            }
        }

        private void AddParticipantDB(Participant participant)
        {
            string query = "INSERT INTO Participants (Id, Name, Email, BirthDate, Concerts) "
                + "VALUES (@id, @name, @email, @birthDate, @concerts)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", participant.Id);
                command.Parameters.AddWithValue("@name", participant.Name);
                command.Parameters.AddWithValue("@email", participant.Email);
                command.Parameters.AddWithValue("@birthDate", participant.BirthDate);

                string concerts = string.Join(",", participant.Concerts);
                command.Parameters.AddWithValue("@concerts", concerts);

                command.ExecuteNonQuery();
            }
        }

        private void UpdateParticipantDB(Participant participant)
        {
            const string query = @"
                UPDATE Participants
                SET
                    Name = @name,
                    Email = @email,
                    BirthDate = @birthDate,
                    Concerts = @concerts
                WHERE
                    Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@id", participant.Id);
                    command.Parameters.AddWithValue("@name", participant.Name);
                    command.Parameters.AddWithValue("@email", participant.Email);
                    command.Parameters.AddWithValue("@birthDate", participant.BirthDate);

                    string concerts = string.Join (",", participant.Concerts);
                    command.Parameters.AddWithValue("@concerts", concerts);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteParticipantDB(Participant participant)
        {
            const string query = "DELETE FROM Participants WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query,connection);
                command.Parameters.AddWithValue("@id", participant.Id);

                command.ExecuteNonQuery();
            }
        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                
                    foreach (var participant in participants)
                    {
                        writer.WriteLine($"Id: {participant.Id}");
                        writer.WriteLine($"Name: {participant.Name}");
                        writer.WriteLine($"Email: {participant.Email}");
                        writer.WriteLine($"Birth Date: {participant.BirthDate.ToShortDateString()}");
                        writer.WriteLine("Concerts: " + string.Join(", ", participant.Concerts));
                        writer.WriteLine();
                    }
                    MessageBox.Show("File saved successfully");
                }
            }
        }
    }
}
