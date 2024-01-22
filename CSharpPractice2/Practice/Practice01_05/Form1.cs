using System;
using System.Windows.Forms;

/*
 *      Temp Convert:
 *      Write a C# Windows App program that 
 *      converts temperatures between Celsius 
 *      and Fahrenheit. 
 *      
 *      Ask the user for the temperature and
 *      the unit. Then convert it.
 */

namespace Practice01_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Declare and initialize global variables
        decimal fahrenheit = 0m;
        decimal celsius = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ConvertTemperature();
        }

        private void ConvertTemperature()
        {
            //if (radCToF.Checked == false &&
            //    radFToC.Checked == false)
            if (!radCToF.Checked &&
                !radFToC.Checked)
            {
                return;
            }
            else if (radCToF.Checked)
            {
                CToFConversion();
            }
            else if (radFToC.Checked)
            {
                FToCConversion();
            }
        }

        private void CToFConversion()
        {
            if ( txtTemperature.Text.Trim() == "")
            {
                return;
            }

            celsius = Decimal.Parse(txtTemperature.Text);
            fahrenheit = (celsius * 1.8m) + 32m;

            txtConvertedTemperature.Text = fahrenheit.ToString("n2");
        }

        private void FToCConversion()
        {
            if (txtTemperature.Text.Trim() == "")
            {
                return;
            }

            fahrenheit = Decimal.Parse(txtTemperature.Text);
            celsius = (fahrenheit - 32m) * 5m / 9m;

            txtConvertedTemperature.Text = celsius.ToString("n2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            radCToF.Checked = false;
            radFToC.Checked = false;
            txtTemperature.Text = "";
            txtConvertedTemperature.Text = "";
            txtTemperature.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                                        "Do You Really Want To Exit The Program?",
                                        "EXIT NOW?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void radCToF_CheckedChanged(object sender, EventArgs e)
        {
            CToFConversion();
        }

        private void radFToC_CheckedChanged(object sender, EventArgs e)
        {
            FToCConversion();
        }
    }
}
