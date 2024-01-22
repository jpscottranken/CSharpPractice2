using System;
using System.IO;
using System.Windows.Forms;

/*
 *      Extra 4-1 Calculate area and perimeter:
 *      
 *      Create a C# form that accepts the 2 integers 
 *      representing the length and width of a 
 *      rectangle from the user and then calculates 
 *      both the area (length *width) and the 
 *      perimeter (2 * length + 2 * width) of the 
 *      rectangle.
 */

namespace Practice01_02
{
    public partial class frmCalculateAreaAndPerimeter : Form
    {
        public frmCalculateAreaAndPerimeter()
        {
            InitializeComponent();
        }

        //  Declare and initialize global variables
        int length = 0;
        int width = 0;
        int area = 0;
        int perimeter = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SetLengthAndWidth();
            CalculateArea();
            CalcuatePerimeter();
        }

        private void SetLengthAndWidth()
        {
            length = Int32.Parse(txtLength.Text);
            width = Int32.Parse(txtWidth.Text);
        }

        private void CalculateArea()
        {
            area = length * width;
            txtArea.Text = area.ToString();
        }

        private void CalcuatePerimeter()
        {
            perimeter = (2 * length + 2 * width);
            txtPerimeter.Text = perimeter.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtLength.Text = "";
            txtWidth.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtLength.Focus();
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
