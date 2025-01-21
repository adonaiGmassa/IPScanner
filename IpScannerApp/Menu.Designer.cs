namespace IpScannerApp
{
    partial class Menu
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
            lblTitreM = new Label();
            txtIp = new TextBox();
            btnValiderM = new Button();
            lblD = new Label();
            SuspendLayout();
            // 
            // lblTitreM
            // 
            lblTitreM.AutoSize = true;
            lblTitreM.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitreM.Location = new Point(309, 19);
            lblTitreM.Name = "lblTitreM";
            lblTitreM.Size = new Size(191, 43);
            lblTitreM.TabIndex = 0;
            lblTitreM.Text = "IpScanner";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(210, 200);
            txtIp.Multiline = true;
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(385, 30);
            txtIp.TabIndex = 1;
            // 
            // btnValiderM
            // 
            btnValiderM.Location = new Point(339, 305);
            btnValiderM.Name = "btnValiderM";
            btnValiderM.Size = new Size(112, 34);
            btnValiderM.TabIndex = 2;
            btnValiderM.Text = "Valider";
            btnValiderM.UseVisualStyleBackColor = true;
            btnValiderM.Click += btnValiderM_Click;
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Font = new Font("Liberation Mono", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblD.Location = new Point(242, 170);
            lblD.Name = "lblD";
            lblD.Size = new Size(320, 27);
            lblD.TabIndex = 3;
            lblD.Text = "Entre votre adresse ip";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblD);
            Controls.Add(btnValiderM);
            Controls.Add(txtIp);
            Controls.Add(lblTitreM);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitreM;
        private TextBox txtIp;
        private Button btnValiderM;
        private Label lblD;
    }
}