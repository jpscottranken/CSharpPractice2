/*
 *  Extra 5-1 Calculate the factorial of a number
 *  =============================================
 *  In this exercise, you'll create Extra5-1Console
 *  and Extra5-1GUI that accepts an integer from the
 *  user and then calculates the factorial of that
 *  integer.
 *  
 *  The factorial of a # is an integer multiplied by
 *  every positive integer less than itself.
 *  
 *  A factorial number is identified by an 
 *  exclamation point following the number.
 *  
 *  Here's how you calculate the factorial of the 
 *  numbers 1 through 5:
 *  
 *  1! = 1 which equals 1 
 *  2! = 2 * 1 which equals 2
 *  3! = 3 * 2 * 1 which equals 6 
 *  4! = 4 * 3 * 2 * 1 which equals 24 
 *  5! = 5 * 4 * 3 * 2 * 1 which equals 120
 *  
 *  To be able to store the large integer values 
 *  for the factorial, this app can't use the 
 *  Int32 data type.
 *  
 *  1.	GUI Only
 *   	Create an event handler for the Click 
 *   	event of the Calculate button. The event 
 *   	handler should get the number the user 
 *   	enters, calculate the factorial of that
 *   	number, display the factorial with commas 
 *   	but	no decimal places, and move the focus 
 *   	to the Number text box. It should return 
 *   	an accurate value for integers from 1 to 20.
 *   	
 *   2. Create an event handler for the Click event 
 *      of the Exit button that closes the form.
 *
 *  3.  Test the app to be sure it works correctly.
 */

namespace Practice02_02g
{
    public partial class frmFactorialConverter : Form
    {
        public frmFactorialConverter()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const int MINNUMBER = 1;
        const int MAXNUMBER = 20;

        //  Declare and initialize class variables
        int number = 0;
        long factorial = -1L;
        bool isValid = false;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            InputNumber();

            if (isValid)
            {
                factorial = CalculateFactorial(number);
                txtFactorial.Text = ($"{number}! = {factorial:n0}");
            }
        }

        private void InputNumber()
        {
            bool result;
            string numberStr = txtNumber.Text;

            //  Check for no input
            if (numberStr == "")
            {
                ShowErrorMessage("You Must Input A Number. Please Try Again.",
                                 "NO INPUT PROVIDED");
                txtNumber.Focus();
                txtFactorial.Text = "";
                isValid = false;
                return;
            }

            //  There was input. Verify that:
            //  1) Input was numeric.
            //  2) Input was within range (1 - 20)
            result = int.TryParse(numberStr, out number);

            if (!result ||
                number < MINNUMBER ||
                number > MAXNUMBER)
            {
                ShowErrorMessage("Non-Numeric Or OOR Input. Please Try Again.",
                                 "INVALID OR OOR INPUT");
                txtNumber.Text = "";
                txtFactorial.Text = "";
                txtNumber.Focus();
                isValid = false;
                return;
            }

            isValid = true;
        }

        private long CalculateFactorial(int n)
        {
            if (n > MAXNUMBER)
            {
                return 0L;
            }

            //6! = 6 * 5 * 4 * 3 * 2 * 1;
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm() 
        {
            txtNumber.Text = "";
            txtFactorial.Text = "";
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

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
