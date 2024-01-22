using System;
using System.Windows.Forms;

/*
 *      Extra 2-1 & Extra 3-1 Design and 
 *      test a simple form:
 *      
 *      Design a C# form that lets the user 
 *      enter a number grade and then displays 
 *      the letter grade when the user clicks 
 *      the Calculate button.
 *      
 *      Use the Ranken grade scale of:
 *      A 	92.5-100% 		Excellent
 *      B+ 	89.5-92.49% 	Very Good
 *      B 	83.5-89.49% 	Good
 *      C+ 	80.5-83.49%	    Above Average
 *      C 	74.5-80.49%	    Average
 *      D 	69.5-74.49% 	Does not satisfy course requirements
 *      F 	0-69.49		    Failing
 */

namespace Practice01_01
{
    public partial class frmLetterGrade : Form
    {
        public frmLetterGrade()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const int MINGRADE =   0;
        const int MAXGRADE = 100;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateLetterGrade();
        }

        private void CalculateLetterGrade()
        {
            int numberGrade = Int32.Parse(txtNumberGrade.Text);
            string letterGrade = "";

            //  Range check
            if (numberGrade < MINGRADE ||  numberGrade > MAXGRADE)
            {
                MessageBox.Show("Number Grade Must Be Between " +
                                MINGRADE + " and " + MAXGRADE,
                                "OUT-OF-RANGE NUMBER GRADE INPUT",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);

                txtNumberGrade.Text = "";
                txtNumberGrade.Focus();
            }
            else if (numberGrade >= 92.5m)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 89.5m)
            {
                letterGrade = "B+";
            }
            else if (numberGrade >= 83.5m)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 80.5m)
            {
                letterGrade = "C+";
            }
            else if (numberGrade >= 74.5m)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 69.5m)
            {
                letterGrade = "D";
            }
            else if (numberGrade >= 0)
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNumberGrade.Text = "";
            txtLetterGrade.Text = "";
            txtNumberGrade.Focus();
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
