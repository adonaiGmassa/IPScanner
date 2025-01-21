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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IpScannerApp
{
    public partial class Menu : Form
    {
        Form1 f = new Form1();  // Créer une nouvelle instance de Form2

        public Menu()
        {
            InitializeComponent();
        }

        private void btnValiderM_Click(object sender, EventArgs e)
        {
            // Récupère le texte saisi dans la TextBox 'txtIp'
            string adresseIp = txtIp.Text;

            // Vérifie si l'adresse IP est non vide et si elle est au bon format (IPv4 ou IPv6)
            bool condition = !string.IsNullOrEmpty(adresseIp) && IPAddress.TryParse(adresseIp, out IPAddress ip);

            // Débute une boucle 'do while' qui continue tant que l'adresse IP n'est pas valide
            do
            {

                if (condition == false)
                {
                    // Si l'adresse IP n'est pas valide au format IPv4 ou IPv6
                    if (!IPAddress.TryParse(adresseIp, out ip))
                    {
                        // Affiche un message d'erreur 
                        MessageBox.Show("Veuillez écrire dans le format IPv4 ou IPv6", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Si l'adresse IP est vide
                    if (string.IsNullOrEmpty(adresseIp))
                    {
                        // Affiche un message d'erreur 
                        MessageBox.Show("Veuillez écrire votre adresse IP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            }
            // Continue tant que la condition n'est pas vraie (c'est-à-dire tant que l'adresse IP n'est pas valide)
            while (condition != true);

            this.Hide(); // Masque le formulaire actuel
            f.Show();  // Affiche Form1 à l'écran
        }

    }

}
