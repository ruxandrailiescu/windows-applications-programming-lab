using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSubject4
{
    public partial class AddEditProduct : Form
    {
        private List<Category> categories;
        public Product Product { get; set; }
        public AddEditProduct(List<Category> _categories)
        {
            InitializeComponent();
            categories = _categories;
            cbCategory.Items.AddRange(categories.Select(c => c.Name).ToArray());

            nudId.Validating += nudId_Validating;
            tbName.Validating += tbName_Validating;
            cbCategory.Validating += cbCategory_Validating;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int id = (int)nudId.Value;
                string name = tbName.Text;
                int units = (int)nudUnits.Value;
                double price = (double)nudPrice.Value;
                int categoryId = categories[cbCategory.SelectedIndex].Id;

                Product = new Product(id, name, units, price, categoryId);
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

        private void cbCategory_Validating(object sender, CancelEventArgs e)
        {
            if(cbCategory.SelectedIndex < 0)
            {
                e.Cancel= true;
                errorProvider1.SetError(cbCategory, "Please choose a category");
            }
        }
    }
}
