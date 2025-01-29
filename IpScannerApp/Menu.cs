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
        FormPrincipal f = new();  // Créer une nouvelle instance du formPrincipal

        public Menu()
        {
            InitializeComponent();
        }

        public void GestionErreur() 
        {
            // Récupère le texte saisi dans la TextBox 'txtIp'
            string adresseIp = txtIp.Text;

            // Vérifie si l'adresse IP est non vide et si elle est à la bonne taille
            bool condition = !string.IsNullOrEmpty(adresseIp) && 
                (adresseIp.Length >= 4 && adresseIp.Length <= 12);

            if (!condition)
            {
                // Si l'adresse IP n'a pas la taille du IPv4 
                if (!(adresseIp.Length >= 4 && adresseIp.Length <= 12))
                {
                    // Affiche un message d'erreur 
                    MessageBox.Show("Veuillez écrire dans le format IPv4", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    // Redemander à l'utilisateur d'entrer une adresse IP valide
                    adresseIp = txtIp.Text; // On met à jour 'adresseIp' avec le texte saisi dans la TextBox

                }

                // Si l'adresse IP est vide
                if (string.IsNullOrEmpty(adresseIp))
                {
                    // Affiche un message d'erreur 
                    MessageBox.Show("Veuillez écrire votre adresse IP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    // Redemander à l'utilisateur d'entrer une adresse IP valide
                    adresseIp = txtIp.Text; // On met à jour 'adresseIp' avec le texte saisi dans la TextBox

                }

            }
            else
            {
                this.Hide(); // Masque le formulaire actuel
                f.Show();  // Affiche Form1 à l'écran
            }

        }

        private void btnValiderM_Click(object sender, EventArgs e)
        {
            GestionErreur();
        }

    }

}
