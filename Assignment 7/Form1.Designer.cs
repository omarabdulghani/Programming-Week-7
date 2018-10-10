namespace Assignment_7
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSquareRef = new System.Windows.Forms.Button();
            this.SquareRefOut = new System.Windows.Forms.Button();
            this.btnSquareValue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(168, 49);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // btnSquareRef
            // 
            this.btnSquareRef.Location = new System.Drawing.Point(35, 118);
            this.btnSquareRef.Name = "btnSquareRef";
            this.btnSquareRef.Size = new System.Drawing.Size(233, 30);
            this.btnSquareRef.TabIndex = 2;
            this.btnSquareRef.Text = "Square By Reference";
            this.btnSquareRef.UseVisualStyleBackColor = true;
            // 
            // SquareRefOut
            // 
            this.SquareRefOut.Location = new System.Drawing.Point(35, 156);
            this.SquareRefOut.Name = "SquareRefOut";
            this.SquareRefOut.Size = new System.Drawing.Size(233, 30);
            this.SquareRefOut.TabIndex = 3;
            this.SquareRefOut.Text = "Square By Reference Out";
            this.SquareRefOut.UseVisualStyleBackColor = true;
            // 
            // btnSquareValue
            // 
            this.btnSquareValue.Location = new System.Drawing.Point(35, 195);
            this.btnSquareValue.Name = "btnSquareValue";
            this.btnSquareValue.Size = new System.Drawing.Size(233, 30);
            this.btnSquareValue.TabIndex = 4;
            this.btnSquareValue.Text = "Square By Value";
            this.btnSquareValue.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(135, 255);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 277);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSquareValue);
            this.Controls.Add(this.SquareRefOut);
            this.Controls.Add(this.btnSquareRef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSquareRef;
        private System.Windows.Forms.Button SquareRefOut;
        private System.Windows.Forms.Button btnSquareValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}

