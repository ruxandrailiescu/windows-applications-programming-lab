using ExamSubject1.Entities;
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

namespace ExamSubject1
{
    public partial class MainForm : Form
    {
        private List<AccessPackage> accessPackages;
        private List<Registration> registrations;

        public MainForm()
        {
            InitializeComponent();
            accessPackages = LoadAccessPackages("C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject1\\ExamSubject1\\Resources\\AccessPackages.txt");
            registrations = new List<Registration>();

            // ListView Setup
            listViewRegistrations.View = View.Details;
            listViewRegistrations.Columns.Add("Company Name", 150);
            listViewRegistrations.Columns.Add("Number of Passes", 100);
            listViewRegistrations.Columns.Add("Access Package", 100);
            listViewRegistrations.FullRowSelect = true;
        }

        private List<AccessPackage> LoadAccessPackages(string filePath)
        {
            List<AccessPackage> packages = new List<AccessPackage>();
            
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach(var line in lines)
                {
                    string[] parts = line.Split(',');
                    if(parts.Length == 3)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        double price = double.Parse(parts[2]);

                        packages.Add(new AccessPackage(id, name, price));
                    }
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }

            return packages;
        }

        private void btnAddReg_Click(object sender, EventArgs e)
        {
            var form = new AddRegistrationForm(accessPackages);
            if(form.ShowDialog() == DialogResult.OK)
            {
                var registration = form.Registration;
                registrations.Add(registration);

                ListViewItem item = new ListViewItem(registration.CompanyName);
                item.SubItems.Add(registration.NoOfPasses.ToString());
                item.SubItems.Add(accessPackages.First(p => p.Id == registration.AccessPackageId).Name);
                item.Tag = registration;

                listViewRegistrations.Items.Add(item);
            }
        }
    }
}
