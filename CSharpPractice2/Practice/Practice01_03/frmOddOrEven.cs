using System;
using System.Windows.Forms;

/*
 *      Is the number Even or Odd:
 *      Write a C# Windows App program to 
 *      check if a  given number is even or odd.
 */

namespace Practice01_03
{
    public partial class frmOddOrEven : Form
    {
        public frmOddOrEven()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateOddEvenStatus();
        }

        private void CalculateOddEvenStatus()
        {
            int number = Int32.Parse(txtNumber.Text);

            if (number % 2 == 0) 
            {
                lblResult.Text = "Even";
            }
            else
            {
                lblResult.Text = "Odd";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm() 
        {
            txtNumber.Text = "";
            lblResult.Text = "";
            txtNumber.Focus();
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
    }
}
