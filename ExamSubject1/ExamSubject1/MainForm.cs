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
using System.Xml.Serialization;

namespace ExamSubject1
{
    public partial class MainForm : Form
    {
        private List<AccessPackage> accessPackages;
        private List<Registration> registrations;
        private const string XmlFilePath = "registrations.xml";

        public MainForm()
        {
            InitializeComponent();
            accessPackages = LoadAccessPackages("C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject1\\ExamSubject1\\Resources\\AccessPackages.txt");
            Registration.SetAccessPackages(accessPackages);
            registrations = LoadRegistrations(XmlFilePath) ?? new List<Registration>();
            //registrations = new List<Registration>();

            // ListView Setup
            listViewRegistrations.View = View.Details;
            listViewRegistrations.Columns.Add("Company Name", 150);
            listViewRegistrations.Columns.Add("Number of Passes", 100);
            listViewRegistrations.Columns.Add("Access Package", 100);
            listViewRegistrations.FullRowSelect = true;
            listViewRegistrations.ContextMenuStrip = contextMenuStrip1;

            PopulateListView();
            UpdateTotalCost();

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

            if (form.ShowDialog() == DialogResult.OK)
            {
                var registration = form.Registration;
                registrations.Add(registration);

                ListViewItem item = new ListViewItem(registration.CompanyName);
                item.SubItems.Add(registration.NoOfPasses.ToString());
                item.SubItems.Add(accessPackages.First(p => p.Id == registration.AccessPackageId).Name);
                item.Tag = registration;

                listViewRegistrations.Items.Add(item);

                UpdateTotalCost();
                SaveRegistrations(XmlFilePath, registrations);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewRegistrations.SelectedItems.Count == 0) 
            {
                e.Cancel = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewRegistrations.SelectedItems.Count > 0)
            {
                var item = listViewRegistrations.SelectedItems[0];
                var registration = (Registration)item.Tag;

                registrations.Remove(registration);
                listViewRegistrations.Items.Remove(item);

                UpdateTotalCost();
                SaveRegistrations(XmlFilePath, registrations);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewRegistrations.SelectedItems.Count > 0)
            {
                var item = listViewRegistrations.SelectedItems[0];
                var registration = (Registration)item.Tag;
                registrations.Remove(registration);

                var form = new AddRegistrationForm(accessPackages, registration);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    registration = form.Registration;
                    registrations.Add(registration);
                    item.SubItems[0].Text = registration.CompanyName;
                    item.SubItems[1].Text = registration.NoOfPasses.ToString();
                    item.SubItems[2].Text = accessPackages.First(p => p.Id == registration.AccessPackageId).Name;
                    item.Tag = registration;

                    UpdateTotalCost();
                    SaveRegistrations(XmlFilePath, registrations);
                }
            }
        }

        private void UpdateTotalCost()
        {
            double totalCost = registrations.Sum(r => (double)r);
            toolStripStatusLabelTotalCost.Text = $"Total Cost: ${totalCost:F2}";
        }

        private void PopulateListView()
        {
            listViewRegistrations.Items.Clear();
            foreach (var registration in registrations)
            {
                ListViewItem item = new ListViewItem(registration.CompanyName);
                item.SubItems.Add(registration.NoOfPasses.ToString());
                item.SubItems.Add(accessPackages.First(p => p.Id == registration.AccessPackageId).Name);
                item.Tag = registration;

                listViewRegistrations.Items.Add(item);
            }
        }

        private void SaveRegistrations(string filePath, List<Registration> registrations)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Registration>));
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, registrations);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save registrations: {ex.Message}");
            }
        }

        private List<Registration> LoadRegistrations(string filePath)
        {
            if (!File.Exists(filePath)) return null;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Registration>));
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return (List<Registration>)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load registrations: {ex.Message}");
                return null;
            }
        }
    }
}
