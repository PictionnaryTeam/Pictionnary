﻿using System.Windows.Forms;
using Pictionnary.Other;

namespace Pictionnary.Forms
{
    public partial class GameEnd : Form
    {
        public GameEnd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the players' name and points
        /// </summary>
        /// <param name="first">First Player</param>
        /// <param name="second">Second Player</param>
        /// <param name="third">Third Player</param>
        public void ShowWinners(Player first, Player second, Player third)
        {
            // Shows the first player info
            lblFirstPlace.Text = $"{first.Name} :";
            lblFirstPoints.Text = $"{first.Points.ToString()} pts";
            lblFirstPodium.Text = first.Name;

            // Shows the second player info
            lblSecondPlace.Text = $"{second.Name} :";
            lblSecondPoints.Text = $"{second.Points.ToString()} pts";
            lblSecondPodium.Text = second.Name;

            // Shows the third player info
            lblThirdPlace.Text = $"{third.Name} :";
            lblThirdPoints.Text = $"{third.Points.ToString()} pts";
            lblThirdPodium.Text = third.Name;
        }

        /// <summary>
        /// Exits the application once the quit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Returns to the home view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, System.EventArgs e)
        {
            FormManager.homeView.Show();
            Hide();
        }
    }
}
