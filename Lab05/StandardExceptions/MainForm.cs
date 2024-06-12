using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardExceptions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the text from tbValue1 and tbValue2 into integers
                int value1 = int.Parse(tbValue1.Text);
                int value2 = int.Parse(tbValue2.Text);

                // Performing integer division and converting the result to a string
                tbResult.Text = (value1 / value2).ToString(CultureInfo.InvariantCulture);

                // Without try-catch block => throwing an exception
            }
            catch (FormatException ex)  // thrown when the format of a string is invalid for a
                                        // particular operation, such as parsing a string
                                        // into a numeric type like an integer
            {
                MessageBox.Show(ex.Message);

                // Rethrowing the exception and displaying the message
                throw;  // handled by Program.Application_ThreadException
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)  // ensure that the application can handle unexpected errors,
                                  // even if they're not explicitly handled in preceding catch blocks
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
