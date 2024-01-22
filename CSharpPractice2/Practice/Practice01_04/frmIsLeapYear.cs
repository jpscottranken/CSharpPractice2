using System;
using System.Windows.Forms;

/*
 *      Is the year a Leap Year:
 *      Write a C# Windows App program to 
 *      check if a given year is a leap 
 *      year or not.
 */

namespace Practice01_04
{
    public partial class frmIsLeapYear : Form
    {
        public frmIsLeapYear()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTheStatus();
        }

        private void CalculateTheStatus()
        {
            int year = Int32.Parse(txtYear.Text);

            if (DateTime.IsLeapYear(year))
            {
                txtLeapYearStatus.Text = year.ToString() + " IS A Leap Year";
            }
            else
            {
                txtLeapYearStatus.Text = year.ToString() + " IS NOT A Leap Year";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtYear.Text = "";
            txtLeapYearStatus.Text = "";
            txtYear.Focus();
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
