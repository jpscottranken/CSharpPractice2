namespace Practice02_02g
{
    partial class frmFactorialConverter
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
            lblNumber = new Label();
            lblFactorial = new Label();
            txtNumber = new TextBox();
            txtFactorial = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCalculate.Location = new Point(88, 322);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(160, 57);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(322, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 57);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnExit.Location = new Point(565, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 57);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // lblNumber
            // 
            lblNumber.BackColor = Color.FromArgb(128, 128, 255);
            lblNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblNumber.ForeColor = Color.White;
            lblNumber.Location = new Point(88, 59);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(160, 31);
            lblNumber.TabIndex = 5;
            lblNumber.Text = "Number:";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFactorial
            // 
            lblFactorial.BackColor = Color.FromArgb(128, 128, 255);
            lblFactorial.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblFactorial.ForeColor = Color.White;
            lblFactorial.Location = new Point(88, 186);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(160, 31);
            lblFactorial.TabIndex = 6;
            lblFactorial.Text = "Factorial:";
            lblFactorial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtNumber.Location = new Point(322, 59);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(160, 38);
            txtNumber.TabIndex = 0;
            txtNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFactorial
            // 
            txtFactorial.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtFactorial.Location = new Point(322, 186);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.ReadOnly = true;
            txtFactorial.Size = new Size(403, 38);
            txtFactorial.TabIndex = 4;
            txtFactorial.TextAlign = HorizontalAlignment.Center;
            // 
            // frmFactorialConverter
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFactorial);
            Controls.Add(txtNumber);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumber);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Name = "frmFactorialConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factorial Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblNumber;
        private Label lblFactorial;
        private TextBox txtNumber;
        private TextBox txtFactorial;
    }
}
