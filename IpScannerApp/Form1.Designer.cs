namespace IpScannerApp
{
    partial class FormPrincipal
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
            txtUtil = new TextBox();
            lblAdressP = new Label();
            lblAdressD = new Label();
            txtDispo = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(388, 404);
            listBox1.TabIndex = 1;
            // 
            // txtUtil
            // 
            txtUtil.BackColor = SystemColors.ScrollBar;
            txtUtil.Enabled = false;
            txtUtil.Location = new Point(454, 139);
            txtUtil.Name = "txtUtil";
            txtUtil.Size = new Size(150, 31);
            txtUtil.TabIndex = 3;
            // 
            // lblAdressP
            // 
            lblAdressP.AutoSize = true;
            lblAdressP.Location = new Point(454, 91);
            lblAdressP.Name = "lblAdressP";
            lblAdressP.Size = new Size(302, 25);
            lblAdressP.TabIndex = 4;
            lblAdressP.Text = "N° d'adresse utilisée sur votre réseau";
            // 
            // lblAdressD
            // 
            lblAdressD.AutoSize = true;
            lblAdressD.Location = new Point(454, 250);
            lblAdressD.Name = "lblAdressD";
            lblAdressD.Size = new Size(317, 25);
            lblAdressD.TabIndex = 5;
            lblAdressD.Text = "N° d'adresse utilisable sur votre réseau";
            // 
            // txtDispo
            // 
            txtDispo.BackColor = SystemColors.ScrollBar;
            txtDispo.Enabled = false;
            txtDispo.Location = new Point(454, 303);
            txtDispo.Name = "txtDispo";
            txtDispo.Size = new Size(150, 31);
            txtDispo.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDispo);
            Controls.Add(lblAdressD);
            Controls.Add(lblAdressP);
            Controls.Add(txtUtil);
            Controls.Add(listBox1);
            Name = "FormPrincipal";
            Text = "IPScanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private TextBox txtUtil;
        private Label lblAdressP;
        private Label lblAdressD;
        private TextBox txtDispo;
    }
}
