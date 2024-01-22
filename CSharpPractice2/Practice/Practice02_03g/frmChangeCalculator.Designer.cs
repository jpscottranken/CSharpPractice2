namespace Practice02_03g
{
    partial class frmChangeCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtChangeDue = new TextBox();
            txtNickels = new TextBox();
            txtPennies = new TextBox();
            txtDimes = new TextBox();
            txtQuarters = new TextBox();
            lblChangeDue = new Label();
            lblNickels = new Label();
            lblDimes = new Label();
            lblQuarters = new Label();
            lblPennies = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(125, 525);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(169, 63);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(352, 525);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(169, 63);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(601, 525);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(169, 63);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtChangeDue
            // 
            txtChangeDue.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtChangeDue.Location = new Point(353, 35);
            txtChangeDue.Name = "txtChangeDue";
            txtChangeDue.Size = new Size(169, 38);
            txtChangeDue.TabIndex = 0;
            txtChangeDue.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNickels
            // 
            txtNickels.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtNickels.Location = new Point(352, 331);
            txtNickels.Name = "txtNickels";
            txtNickels.ReadOnly = true;
            txtNickels.Size = new Size(169, 38);
            txtNickels.TabIndex = 6;
            txtNickels.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPennies
            // 
            txtPennies.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtPennies.Location = new Point(352, 430);
            txtPennies.Name = "txtPennies";
            txtPennies.ReadOnly = true;
            txtPennies.Size = new Size(169, 38);
            txtPennies.TabIndex = 7;
            txtPennies.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDimes
            // 
            txtDimes.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtDimes.Location = new Point(353, 233);
            txtDimes.Name = "txtDimes";
            txtDimes.ReadOnly = true;
            txtDimes.Size = new Size(169, 38);
            txtDimes.TabIndex = 5;
            txtDimes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQuarters
            // 
            txtQuarters.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtQuarters.Location = new Point(352, 134);
            txtQuarters.Name = "txtQuarters";
            txtQuarters.ReadOnly = true;
            txtQuarters.Size = new Size(169, 38);
            txtQuarters.TabIndex = 4;
            txtQuarters.TextAlign = HorizontalAlignment.Center;
            // 
            // lblChangeDue
            // 
            lblChangeDue.BackColor = Color.FromArgb(128, 255, 128);
            lblChangeDue.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblChangeDue.Location = new Point(126, 35);
            lblChangeDue.Name = "lblChangeDue";
            lblChangeDue.Size = new Size(169, 36);
            lblChangeDue.TabIndex = 8;
            lblChangeDue.Text = "Change Due:";
            lblChangeDue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNickels
            // 
            lblNickels.BackColor = Color.FromArgb(128, 255, 128);
            lblNickels.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblNickels.Location = new Point(125, 331);
            lblNickels.Name = "lblNickels";
            lblNickels.Size = new Size(169, 36);
            lblNickels.TabIndex = 11;
            lblNickels.Text = "Nickels:";
            lblNickels.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDimes
            // 
            lblDimes.BackColor = Color.FromArgb(128, 255, 128);
            lblDimes.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblDimes.Location = new Point(126, 236);
            lblDimes.Name = "lblDimes";
            lblDimes.Size = new Size(169, 36);
            lblDimes.TabIndex = 10;
            lblDimes.Text = "Dimes:";
            lblDimes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuarters
            // 
            lblQuarters.BackColor = Color.FromArgb(128, 255, 128);
            lblQuarters.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblQuarters.Location = new Point(125, 137);
            lblQuarters.Name = "lblQuarters";
            lblQuarters.Size = new Size(169, 36);
            lblQuarters.TabIndex = 9;
            lblQuarters.Text = "Quarters:";
            lblQuarters.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPennies
            // 
            lblPennies.BackColor = Color.FromArgb(128, 255, 128);
            lblPennies.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblPennies.Location = new Point(125, 430);
            lblPennies.Name = "lblPennies";
            lblPennies.Size = new Size(169, 36);
            lblPennies.TabIndex = 12;
            lblPennies.Text = "Pennies:";
            lblPennies.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChangeCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            CancelButton = btnClear;
            ClientSize = new Size(875, 632);
            Controls.Add(lblPennies);
            Controls.Add(lblQuarters);
            Controls.Add(lblDimes);
            Controls.Add(lblNickels);
            Controls.Add(lblChangeDue);
            Controls.Add(txtQuarters);
            Controls.Add(txtDimes);
            Controls.Add(txtPennies);
            Controls.Add(txtNickels);
            Controls.Add(txtChangeDue);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Name = "frmChangeCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtChangeDue;
        private TextBox txtNickels;
        private TextBox txtPennies;
        private TextBox txtDimes;
        private TextBox txtQuarters;
        private Label lblChangeDue;
        private Label lblNickels;
        private Label lblDimes;
        private Label lblQuarters;
        private Label lblPennies;
    }
}
