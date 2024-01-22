namespace Practice02_04g2
{
    public partial class frmIncomeTaxCalculator : Form
    {
        public frmIncomeTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DetermineTaxableIncome();
        }

        private void DetermineTaxableIncome()
        {

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


    }
}
