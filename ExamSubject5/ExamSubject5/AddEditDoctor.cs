using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
