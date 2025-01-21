using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IpScannerApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnValiderM_Click(object sender, EventArgs e)
        {
            string adresseIp = txtIp.Text;
            bool condition = !string.IsNullOrEmpty(adresseIp) && IPAddress.TryParse(adresseIp, out IPAddress ip);

            do
            {
                if (condition == false) 
                {
                    if (!IPAddress.TryParse(adresseIp,out ip)) 
                    {
                        MessageBox.Show("Veuillez ecrire dans le format ipv4", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (string.IsNullOrEmpty(adresseIp))
                    {
                        MessageBox.Show("Veuillez écrire votre adresse IP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            while (condition!=true);

        }
    }
}
