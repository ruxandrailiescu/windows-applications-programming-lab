using ExamSubject3.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridViewParticipants.Rows.Clear();

            foreach (var participant in participants)
            {
                string concerts = string.Join(", ", participant.Concerts);

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
                }
            }
        }

        private void dataGridViewParticipants_Click(object sender, EventArgs e)
        {
            // Delete
            if (dataGridViewParticipants.SelectedRows.Count > 0)
            {
                var item = dataGridViewParticipants.SelectedRows[0];
                var participant = (Participant)item.Tag;
                participants.Remove(participant);
                PopulateDataGridView();
            }
        }
    }
}
