﻿namespace IpScannerApp
{
    partial class Form1
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblAdressP = new Label();
            lblAdressD = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 184);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 254);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // lblAdressP
            // 
            lblAdressP.AutoSize = true;
            lblAdressP.Location = new Point(12, 9);
            lblAdressP.Name = "lblAdressP";
            lblAdressP.Size = new Size(302, 25);
            lblAdressP.TabIndex = 4;
            lblAdressP.Text = "N° d'adresse utilisée sur votre réseau";
            // 
            // lblAdressD
            // 
            lblAdressD.AutoSize = true;
            lblAdressD.Location = new Point(12, 90);
            lblAdressD.Name = "lblAdressD";
            lblAdressD.Size = new Size(317, 25);
            lblAdressD.TabIndex = 5;
            lblAdressD.Text = "N° d'adresse utilisable sur votre réseau";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAdressD);
            Controls.Add(lblAdressP);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblAdressP;
        private Label lblAdressD;
    }
}
