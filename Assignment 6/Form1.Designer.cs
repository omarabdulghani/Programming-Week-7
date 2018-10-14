namespace Assignment_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDegrees = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFtoC = new System.Windows.Forms.RadioButton();
            this.rdCtoF = new System.Windows.Forms.RadioButton();
            this.rdCtoK = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // txtDegrees
            // 
            this.txtDegrees.Location = new System.Drawing.Point(149, 32);
            this.txtDegrees.Name = "txtDegrees";
            this.txtDegrees.Size = new System.Drawing.Size(119, 20);
            this.txtDegrees.TabIndex = 1;
            this.txtDegrees.TextChanged += new System.EventHandler(this.txtDegrees_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFtoC);
            this.groupBox1.Controls.Add(this.rdCtoF);
            this.groupBox1.Controls.Add(this.rdCtoK);
            this.groupBox1.Location = new System.Drawing.Point(41, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // rdFtoC
            // 
            this.rdFtoC.AutoSize = true;
            this.rdFtoC.Location = new System.Drawing.Point(29, 86);
            this.rdFtoC.Name = "rdFtoC";
            this.rdFtoC.Size = new System.Drawing.Size(124, 17);
            this.rdFtoC.TabIndex = 2;
            this.rdFtoC.TabStop = true;
            this.rdFtoC.Text = "Fahrenheit to Celcius";
            this.rdFtoC.UseVisualStyleBackColor = true;
            // 
            // rdCtoF
            // 
            this.rdCtoF.AutoSize = true;
            this.rdCtoF.Location = new System.Drawing.Point(29, 63);
            this.rdCtoF.Name = "rdCtoF";
            this.rdCtoF.Size = new System.Drawing.Size(124, 17);
            this.rdCtoF.TabIndex = 1;
            this.rdCtoF.TabStop = true;
            this.rdCtoF.Text = "Celcius to Fahrenheit";
            this.rdCtoF.UseVisualStyleBackColor = true;
            // 
            // rdCtoK
            // 
            this.rdCtoK.AutoSize = true;
            this.rdCtoK.Location = new System.Drawing.Point(29, 39);
            this.rdCtoK.Name = "rdCtoK";
            this.rdCtoK.Size = new System.Drawing.Size(103, 17);
            this.rdCtoK.TabIndex = 0;
            this.rdCtoK.TabStop = true;
            this.rdCtoK.Text = "Celcius to Kelvin";
            this.rdCtoK.UseVisualStyleBackColor = true;
            this.rdCtoK.CheckedChanged += new System.EventHandler(this.rdCtoK_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(41, 224);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(227, 35);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted Degrees";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(179, 290);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 316);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDegrees);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDegrees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdFtoC;
        private System.Windows.Forms.RadioButton rdCtoF;
        private System.Windows.Forms.RadioButton rdCtoK;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}

