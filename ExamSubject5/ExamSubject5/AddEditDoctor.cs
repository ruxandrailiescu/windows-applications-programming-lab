using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExamSubject5
{
    public partial class AddEditDoctor : Form
    {
        private List<Specialty> specialties;
        public Doctor Doctor { get; set; }
        public AddEditDoctor(List<Specialty> _specialties)
        {
            InitializeComponent();
            specialties = _specialties;
            lbSpecialty.Items.AddRange(specialties.Select(s => s.Name).ToArray());

            nudId.Validating += nudId_Validating;
            tbName.Validating += tbName_Validating;
            dtpBirthDate.Validating += dtpBirthDate_Validating;
            lbSpecialty.Validating += lbSpecialty_Validating;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int id = (int)nudId.Value;
                string name = tbName.Text;
                DateTime birthDate = dtpBirthDate.Value;
                double wage = (double)nudWage.Value;
                int specialtyId = specialties[lbSpecialty.SelectedIndex].Id;

                Doctor = new Doctor(id, name, birthDate, wage, specialtyId);
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
            if(nudId.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudId, "Id cannot be 0");
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Name cannot be empty");
            }
        }

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime minDate = today.AddYears(-70);
            DateTime maxDate = today.AddYears(-25);

            if (dtpBirthDate.Value < minDate || dtpBirthDate.Value > maxDate)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpBirthDate, "Age should be between 25 and 70");
            }
        }

        private void lbSpecialty_Validating(object sender, CancelEventArgs e)
        {
            if (lbSpecialty.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(lbSpecialty, "Please select a specialty");
            }
        }
    }
}
