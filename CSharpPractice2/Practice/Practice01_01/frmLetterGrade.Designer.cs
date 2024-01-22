namespace Practice01_01
{
    partial class frmLetterGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumbefGade = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumbefGade
            // 
            this.lblNumbefGade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNumbefGade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbefGade.ForeColor = System.Drawing.Color.White;
            this.lblNumbefGade.Location = new System.Drawing.Point(176, 86);
            this.lblNumbefGade.Name = "lblNumbefGade";
            this.lblNumbefGade.Size = new System.Drawing.Size(185, 34);
            this.lblNumbefGade.TabIndex = 5;
            this.lblNumbefGade.Text = "Number Grade:";
            this.lblNumbefGade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblLetterGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterGrade.ForeColor = System.Drawing.Color.White;
            this.lblLetterGrade.Location = new System.Drawing.Point(176, 175);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(185, 34);
            this.lblLetterGrade.TabIndex = 6;
            this.lblLetterGrade.Text = "Letter Grade:";
            this.lblLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberGrade.Location = new System.Drawing.Point(399, 86);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(156, 38);
            this.txtNumberGrade.TabIndex = 0;
            this.txtNumberGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetterGrade.Location = new System.Drawing.Point(399, 175);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.ReadOnly = true;
            this.txtLetterGrade.Size = new System.Drawing.Size(156, 38);
            this.txtLetterGrade.TabIndex = 4;
            this.txtLetterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(76, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 65);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(318, 284);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 65);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(552, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLetterGrade
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.lblNumbefGade);
            this.Name = "frmLetterGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbefGade;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

