namespace StringToHex
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
            this.tbStringValue = new System.Windows.Forms.TextBox();
            this.tbHexValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbReversed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStringValue
            // 
            this.tbStringValue.Location = new System.Drawing.Point(126, 37);
            this.tbStringValue.Name = "tbStringValue";
            this.tbStringValue.Size = new System.Drawing.Size(224, 20);
            this.tbStringValue.TabIndex = 0;
            // 
            // tbHexValue
            // 
            this.tbHexValue.Location = new System.Drawing.Point(126, 78);
            this.tbHexValue.Name = "tbHexValue";
            this.tbHexValue.ReadOnly = true;
            this.tbHexValue.Size = new System.Drawing.Size(224, 20);
            this.tbHexValue.TabIndex = 1;
            this.tbHexValue.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbReversed
            // 
            this.tbReversed.Location = new System.Drawing.Point(126, 111);
            this.tbReversed.Name = "tbReversed";
            this.tbReversed.ReadOnly = true;
            this.tbReversed.Size = new System.Drawing.Size(224, 20);
            this.tbReversed.TabIndex = 3;
            this.tbReversed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Strengværdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hex værdi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reversed Hex værdi ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReversed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbHexValue);
            this.Controls.Add(this.tbStringValue);
            this.Name = "Form1";
            this.Text = "StringToHexConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStringValue;
        private System.Windows.Forms.TextBox tbHexValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbReversed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

