namespace ConvertTempClient
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(119, 63);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 0;
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(77, 118);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(157, 23);
            this.btnFtoC.TabIndex = 1;
            this.btnFtoC.Text = "Fahrenheit To Celsius";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(240, 118);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(144, 23);
            this.btnCtoF.TabIndex = 2;
            this.btnCtoF.Text = "CelsiusToFahrenheit";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(119, 172);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 3;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(74, 66);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(35, 16);
            this.lbInput.TabIndex = 4;
            this.lbInput.Text = "Input";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(65, 178);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(45, 16);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbResult;
    }
}

