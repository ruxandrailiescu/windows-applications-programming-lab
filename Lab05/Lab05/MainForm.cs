using Lab05.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab05
{
    public partial class MainForm : Form
    {
        private List<Participant> _participants;

        public MainForm()
        {
            _participants = new List<Participant>();
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

                // Add participant in the list
                _participants.Add(participant);
                DisplayParticipants();

                // Clear values after adding a participant
                tbFirstName.Text = "";
                tbLastName.Text = "";
                dtpBirthDate.Value = DateTime.Now;
                tbSSN.Text = "";
                cbMale.Checked = true;

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

        private void DisplayParticipants()
        {
            lvParticipants.Items.Clear();

            foreach (Participant participant in _participants)
            {
                var item = new ListViewItem(participant.LastName);
                item.SubItems.Add(participant.FirstName);
                item.SubItems.Add(participant.BirthDate.ToShortDateString());
                item.SubItems.Add(participant.Gender.ToString());
                item.SubItems.Add(participant.SSN);

                // Check if participant is an adult or child
                if (participant.BirthDate < new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day))
                {
                    item.ImageKey = "adult.png";
                    item.Group = lvParticipants.Groups["Adults"];
                }
                else
                {
                    item.ImageKey = "child.png";
                    item.Group = lvParticipants.Groups["Children"];
                }

                lvParticipants.Items.Add(item);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            lvParticipants.View = View.Details;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lvParticipants.View = View.List;
        }

        private void btnLargeIcon_Click(object sender, EventArgs e)
        {
            lvParticipants.View = View.LargeIcon;
        }

        private void btnSmallIcon_Click(object sender, EventArgs e)
        {
            lvParticipants.View = View.SmallIcon;
        }

        private void btnTile_Click(object sender, EventArgs e)
        {
            lvParticipants.View = View.Tile;
        }

        // Serialization involves converting the state of an object or a data structure
        // into a byte stream or another format that preserves its state and structure

        // The list of Participant objects will be converted into a binary representation
        private void btnSerializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("serializedBinary.bin"))  // store content in this file,
                                                                             // inside bin folder
            {
                formatter.Serialize(stream, _participants);
            }
        }

        // The application will read the serialized data from the "serializedBinary.bin" file located in the bin folder,
        // deserialize it back into the _participants list, and then update the UI by displaying the participants
        private void btnDeserializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serializedBinary.bin"))
            {
                _participants = (List<Participant>)formatter.Deserialize(stream);
                DisplayParticipants();
            }
        }

        // Handles the serialization of data from the _participants list into an XML file
        // The content of the file is human-readable compared to binary serialization
        private void btnSerializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            using (FileStream stream = File.Create("serializedXML.xml"))
            {
                serializer.Serialize(stream, _participants);
            }
        }

        // Handles the deserialization of XML data from a file back into the _participants list
        private void btnDeserializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Participant>));
            using (FileStream stream = File.OpenRead("serializedXML.xml"))
            {
                _participants = (List<Participant>)serializer.Deserialize(stream);
                DisplayParticipants();
            }
        }

        // Install package Newtonsoft.Json
        // JSON is more readable and compact compared to XML
        private void btnSerializeJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter writer = File.CreateText("serializedJSON.json"))
            {
                serializer.Serialize(writer, _participants);
            }
        }

        private void btnDeserializeJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader("serializedJSON.json"))
            {
                _participants = (List<Participant>)serializer.Deserialize(reader, typeof(List<Participant>));
                DisplayParticipants();
            }
        }

        private void btnExportTextFile_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("LastName,FirstName,BirthDate,Gender,SSN");

                    foreach (var participant in _participants)
                    {
                        writer.WriteLine("\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\""
                            , participant.LastName.Replace("\"", "\"\"")
                            , participant.FirstName.Replace("\"", "\"\"")
                            , participant.BirthDate.ToShortDateString()
                            , participant.Gender.ToString()
                            , participant.SSN.Replace("\"", "\"\""));
                    }
                }
            }
        }
    }
}
