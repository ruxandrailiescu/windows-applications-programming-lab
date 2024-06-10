using ExamSubject1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSubject1
{
    public partial class AddRegistrationForm : Form
    {
        private List<AccessPackage> accessPackages;
        public Registration Registration { get; private set; }

        public AddRegistrationForm(List<AccessPackage> packages, Registration registration = null)
        {
            InitializeComponent();
            accessPackages = packages;

            cbAccessPackage.Items.AddRange(accessPackages.Select(p => p.Name).ToArray());

            if(registration != null )
            {
                tbCompanyName.Text = registration.CompanyName;
                nudNoOfPasses.Value = registration.NoOfPasses;
                cbAccessPackage.SelectedIndex = accessPackages.FindIndex(p => p.Id == registration.AccessPackageId);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string companyName = tbCompanyName.Text;
            int noOfPasses = (int)nudNoOfPasses.Value;
            int selectedIndex = cbAccessPackage.SelectedIndex;

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Company name cannot be empty.");
                return;
            }

            if(selectedIndex < 0)
            {
                MessageBox.Show("Please select an access package.");
                return;
            }

            int accessPackageId = accessPackages[selectedIndex].Id;
            Registration = new Registration(companyName, noOfPasses, accessPackageId);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
