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
            PopulateDataGridView();
            //dataGridViewSmartphones.DataSource = _smartphones;
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

        private void PopulateDataGridView()
        {
            dataGridViewSmartphones.Rows.Clear();

            string producer = "";
            int indexRow = 0;

            foreach (var smartphone in _smartphones)
            {
                producer = _producers.First(p => p.Id == smartphone.ProducerId).Name;
                indexRow = dataGridViewSmartphones.Rows.Add(
                    smartphone.Id.ToString(), 
                    smartphone.Model,
                    smartphone.Units.ToString(), 
                    smartphone.Price.ToString(), 
                    smartphone.ReleaseDate.ToString("dd/mm/yyyy"),
                    producer);
                dataGridViewSmartphones.Rows[indexRow].Tag = smartphone;
            }
        }

        private void dataGridViewSmartphones_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewSmartphones.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnAddSmartphone_Click(object sender, EventArgs e)
        {
            var form = new AddEditSmartphoneForm(_producers);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var smartphone = form.Smartphone;
                _smartphones.Add(smartphone);
                _smartphones.Sort();
                PopulateDataGridView();
                //dataGridViewSmartphones.DataSource = null;
                //dataGridViewSmartphones.DataSource = _smartphones;
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
                    _smartphones.Sort();
                    PopulateDataGridView();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewSmartphones.SelectedRows.Count > 0)
            {
                var item = dataGridViewSmartphones.SelectedRows[0];
                var smartphone = (Smartphone)item.Tag;
                _smartphones.Remove(smartphone);
                PopulateDataGridView();
            }
        }
    }
}
