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
    public partial class AddEditParticipant : Form
    {
        public Participant Participant { get; set; }
        public AddEditParticipant(List<string> concertArray, Participant participant = null)
        {
            InitializeComponent();
            checkedListBoxConcerts.Items.AddRange(concertArray.ToArray());

            nudId.Validating += nudId_Validating;
            tbName.Validating += tbName_Validating;
            tbEmail.Validating += tbEmail_Validating;
            dtpBirthDate.Validating += dtpBirthDate_Validating;

            if (participant != null)
            {
                nudId.Value = participant.Id;
                tbName.Text = participant.Name;
                tbEmail.Text = participant.Email;
                dtpBirthDate.Value = participant.BirthDate;

                foreach (var concert in participant.Concerts)
                {
                    for (int i = 0; i < checkedListBoxConcerts.Items.Count; i++)
                    {
                        if (concert.Equals(checkedListBoxConcerts.Items[i]))
                        {
                            checkedListBoxConcerts.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int id = (int)nudId.Value;
                string name = tbName.Text;
                string email = tbEmail.Text;
                DateTime birthDate = dtpBirthDate.Value;
                List<string> concerts = new List<string>();

                foreach (var concert in checkedListBoxConcerts.CheckedItems)
                {
                    concerts.Add(concert.ToString());
                }

                Participant = new Participant(id, name, email, birthDate, concerts);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void nudId_Validating(object sender, CancelEventArgs e)
        {
            if (nudId.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudId, "Id cannot be 0");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudId, null);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Name cannot be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Email cannot be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, null);
            }
        }

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpBirthDate.Value >= DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpBirthDate, "Birth date cannot be in the future");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpBirthDate, null);
            }
        }
    }
}
