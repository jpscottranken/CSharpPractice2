namespace Practice01_05
{
    partial class Form1
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
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblConvertedTemperature = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtConvertedTemperature = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbTempConverter = new System.Windows.Forms.GroupBox();
            this.radFToC = new System.Windows.Forms.RadioButton();
            this.radCToF = new System.Windows.Forms.RadioButton();
            this.gbTempConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTemperature.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(146, 180);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(294, 36);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "Temperature:";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConvertedTemperature
            // 
            this.lblConvertedTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblConvertedTemperature.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedTemperature.Location = new System.Drawing.Point(140, 248);
            this.lblConvertedTemperature.Name = "lblConvertedTemperature";
            this.lblConvertedTemperature.Size = new System.Drawing.Size(300, 36);
            this.lblConvertedTemperature.TabIndex = 7;
            this.lblConvertedTemperature.Text = "Converted Temperature:";
            this.lblConvertedTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(499, 177);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(191, 38);
            this.txtTemperature.TabIndex = 0;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConvertedTemperature
            // 
            this.txtConvertedTemperature.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertedTemperature.Location = new System.Drawing.Point(499, 248);
            this.txtConvertedTemperature.Name = "txtConvertedTemperature";
            this.txtConvertedTemperature.ReadOnly = true;
            this.txtConvertedTemperature.Size = new System.Drawing.Size(191, 38);
            this.txtConvertedTemperature.TabIndex = 5;
            this.txtConvertedTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(75, 337);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 57);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(318, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 57);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(567, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbTempConverter
            // 
            this.gbTempConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbTempConverter.Controls.Add(this.radFToC);
            this.gbTempConverter.Controls.Add(this.radCToF);
            this.gbTempConverter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTempConverter.Location = new System.Drawing.Point(140, 59);
            this.gbTempConverter.Name = "gbTempConverter";
            this.gbTempConverter.Size = new System.Drawing.Size(587, 65);
            this.gbTempConverter.TabIndex = 4;
            this.gbTempConverter.TabStop = false;
            this.gbTempConverter.Text = "Temp Converter";
            // 
            // radFToC
            // 
            this.radFToC.AutoSize = true;
            this.radFToC.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFToC.Location = new System.Drawing.Point(388, 24);
            this.radFToC.Name = "radFToC";
            this.radFToC.Size = new System.Drawing.Size(102, 35);
            this.radFToC.TabIndex = 1;
            this.radFToC.TabStop = true;
            this.radFToC.Text = "F To C";
            this.radFToC.UseVisualStyleBackColor = true;
            this.radFToC.CheckedChanged += new System.EventHandler(this.radFToC_CheckedChanged);
            // 
            // radCToF
            // 
            this.radCToF.AutoSize = true;
            this.radCToF.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCToF.Location = new System.Drawing.Point(116, 24);
            this.radCToF.Name = "radCToF";
            this.radCToF.Size = new System.Drawing.Size(102, 35);
            this.radCToF.TabIndex = 0;
            this.radCToF.TabStop = true;
            this.radCToF.Text = "C To F";
            this.radCToF.UseVisualStyleBackColor = true;
            this.radCToF.CheckedChanged += new System.EventHandler(this.radCToF_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTempConverter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtConvertedTemperature);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lblConvertedTemperature);
            this.Controls.Add(this.lblTemperature);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbTempConverter.ResumeLayout(false);
            this.gbTempConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblConvertedTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtConvertedTemperature;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbTempConverter;
        private System.Windows.Forms.RadioButton radFToC;
        private System.Windows.Forms.RadioButton radCToF;
    }
}

