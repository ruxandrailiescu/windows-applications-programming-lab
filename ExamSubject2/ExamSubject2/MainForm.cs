using ExamSubject2.Entities;
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

namespace ExamSubject2
{
    public partial class MainForm : Form
    {
        private List<Producer> _producers;
        private List<Smartphone> _smartphones;
        public MainForm()
        {
            InitializeComponent();
            _producers = LoadProducers("C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject2\\ExamSubject2\\Resources\\Data.txt");
            _smartphones = new List<Smartphone>();
            dataGridViewSmartphones.DataSource = _smartphones;
            dataGridViewSmartphones.ContextMenuStrip = contextMenuStrip1;
        }

        private List<Producer> LoadProducers(string filePath)
        {
            List<Producer> producers = new List<Producer>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];

                        producers.Add(new Producer(id, name));
                    }
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }

            return producers;
        }

        private void btnAddSmartphone_Click(object sender, EventArgs e)
        {
            var form = new AddEditSmartphoneForm(_producers);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var smartphone = form.Smartphone;
                _smartphones.Add(smartphone);

                dataGridViewSmartphones.DataSource = null;
                dataGridViewSmartphones.DataSource = _smartphones;
                dataGridViewSmartphones.Tag = smartphone;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewSmartphones.SelectedRows.Count > 0)
            {
                var item = dataGridViewSmartphones.SelectedRows[0];
                var smartphone = (Smartphone)item.Tag;

                var form = new AddEditSmartphoneForm(_producers, smartphone);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _smartphones.Remove(smartphone);
                    smartphone = form.Smartphone;
                    _smartphones.Add(smartphone);
                    dataGridViewSmartphones.DataSource = null;
                    dataGridViewSmartphones.DataSource= _smartphones;
                    dataGridViewSmartphones.Tag= smartphone;
                }
            }
        }
    }
}
