namespace Practice02_04g2
{
    public partial class frmIncomeTaxCalculator : Form
    {
        //  Declare and initialize class variables
        decimal income = 0.00m;
        bool isValid   = false;

        public frmIncomeTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            InputIncome();
            if (isValid)
            {
                DetermineTaxableIncome();
            }
        }

        private void InputIncome()
        {
            bool result;

            string incomeStr = txtTaxableIncome.Text.Trim();
            if (incomeStr == "")
            {
                ShowErrorMessage("You Must Input A Number.",
                                 "NO VALUE INPUTTED");
                txtTaxableIncome.Focus();
                isValid = false;
                return;
            }

            result = decimal.TryParse(incomeStr, out income);
            if (!result || income <= 0)
            {
                ShowErrorMessage("Non-Numeric or Numberr OOR",
                                 "INVALID OR OOR INPUT");
                txtTaxableIncome.Text = "";
                txtTaxableIncome.Focus();
                isValid = false;
                return;
            }

            isValid = true;
        }


        private void DetermineTaxableIncome()
        {
            decimal taxDue = 0.00m;
            txtIncomeTaxOwed.Text = "";

            if (income >= 578125)
            {
                taxDue = 174238.25m + ((income - 578125m) * 0.37m);
            }
            else if (income >= 231250)
            {
                taxDue = 52832.00m + ((income - 231250m) * 0.35m);
            }
            else if (income >= 182100)
            {
                taxDue = 37104.00m + ((income - 182100) * 0.32m);
            }
            else if (income >= 95375)
            {
                taxDue = 16290.00m + ((income - 95375) * 0.24m);
            }
            else if (income >= 44725)
            {
                taxDue = 5147.00m + ((income - 44725) * 0.22m);
            }
            else if (income >= 11000)
            {
                taxDue = 1100.00m + ((income - 11000) * 0.12m);
            }
            else if (income > 0)
            {
                taxDue = 0.00m + (income * 0.10m);
            }

           txtIncomeTaxOwed.Text = ($"{taxDue:c}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTaxableIncome.Text = "";
            txtIncomeTaxOwed.Text = "";
            txtTaxableIncome.Focus();
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
