using Lab05.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsLastNameValid()
        {
            return !string.IsNullOrWhiteSpace(tbLastName.Text.Trim());
        }

        private bool IsFirstNameValid()
        {
            return !string.IsNullOrWhiteSpace((tbFirstName.Text.Trim()));
        }

        // Checks if the last name entered by the user is valid
        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsLastNameValid())
            {
                e.Cancel = true;    // prevents the user from changing the focus to another control
                errorProvider.SetError((Control)sender, "Last Name is empty!");     // display error message
            }
        }

        // Clears any error message displayed if the last name input is valid
        private void tbLastName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(!IsFirstNameValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "First Name is empty");
            }
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check for validation errors in child controls of the form
            // and display a message if errors are found,
            // preventing further action until they are resolved

            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                string firstName = tbFirstName.Text.Trim();
                string lastName = tbLastName.Text.Trim();
                DateTime birthDate = dtpBirthDate.Value;
                string ssn = tbSSN.Text.Trim();

                GenderEnum gender = GenderEnum.Male;
                if (cbFemale.Checked)
                    gender = GenderEnum.Female;

                var participant = new Participant(lastName, firstName, birthDate, gender, ssn);
            }
            catch (InvalidBirthDateException ex)
            {
                // Expected exception
                MessageBox.Show(string.Format("The birth date {0} is invalid!", ex.BirthDate));
            }
            catch (Exception)
            {
                // Unexpected exception
                MessageBox.Show("An exception has been encountered!");
            }
            finally
            {
                Debug.WriteLine("Always executed");
            }
        }
    }
}
