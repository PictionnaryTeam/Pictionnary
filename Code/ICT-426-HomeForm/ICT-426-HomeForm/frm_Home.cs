///ETML
///Auteur : lopezes
///Date : 28.01.2019
///Description : Page d'accueil pour le projet Pictionnary
using System;
using System.Windows.Forms;

namespace ICT_426_HomeForm
{
    public partial class frm_Home : Form
    {

        /// <summary>
        /// Constructeur
        /// </summary>
        public frm_Home()
        {
            InitializeComponent();
            Icon = ICT_426_HomeForm.Properties.Resources.frm_HomeIcon;
        }

        /// <summary>
        /// Informe à l'utilisateur que la fonctionnalité sera bientôt disponible
        /// </summary>
        /// <param name="sender">Bouton cliqué</param>
        /// <param name="e">Event</param>
        private void buttonFormHomeClick(object sender, EventArgs e)
        {

            MessageBox.Show("La fonctionnalité sera bientôt implémentée");

        }

    }
}
