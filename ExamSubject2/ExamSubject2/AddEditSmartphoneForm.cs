using ExamSubject2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSubject2
{
    public partial class AddEditSmartphoneForm : Form
    {
        private List<Producer> _producers;
        public Smartphone Smartphone {  get; set; }
        public AddEditSmartphoneForm(List<Producer> producers, Smartphone smartphone = null)
        {
            InitializeComponent();
            _producers = producers;

            cbProdId.Items.AddRange(_producers.Select(p => p.Name).ToArray());

            if (smartphone != null)
            {
                nudId.Value = smartphone.Id;
                tbModel.Text = smartphone.Model;
                nudUnits.Value = smartphone.Units;
                nudPrice.Value = (decimal)smartphone.Price;
                dtpReleaseDate.Value = smartphone.ReleaseDate;
                cbProdId.SelectedIndex = _producers.FindIndex(p => p.Id == smartphone.ProducerId);
            }

            nudId.Validating += nudId_Validating;
            tbModel.Validating += tbModel_Validating;
            nudUnits.Validating += nudUnits_Validating;
            nudPrice.Validating += nudPrice_Validating;
            dtpReleaseDate.Validating += dtpReleaseDate_Validating;
            cbProdId.Validating += cbProdId_Validating;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int id = (int)nudId.Value;
                string model = tbModel.Text;
                int units = (int)nudUnits.Value;
                double price = (double)nudPrice.Value;
                DateTime releaseDate = dtpReleaseDate.Value;

                int selectedIndex = cbProdId.SelectedIndex;
                int producerId = _producers[selectedIndex].Id;
                
                Smartphone = new Smartphone(id, model, units, price, releaseDate, producerId);

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

        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbModel.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbModel, "Model cannot be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbModel, null);
            }
        }

        private void nudUnits_Validating(object sender, CancelEventArgs e)
        {
            if (nudUnits.Value == 0)
            {
                e.Cancel= true;
                errorProvider1.SetError(nudUnits, "Units cannot be 0");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudUnits, null);
            }
        }

        private void nudPrice_Validating(object sender, CancelEventArgs e)
        {
            if (nudPrice.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudPrice, "Price cannot be 0");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nudPrice, null);
            }
        }

        private void dtpReleaseDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpReleaseDate.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpReleaseDate, "Release date cannot be in the future");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpReleaseDate, null);
            }
        }

        private void cbProdId_Validating(object sender, CancelEventArgs e)
        {
            if (cbProdId.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbProdId, "Please select a producer");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbProdId, null);
            }
        }
    }
}
