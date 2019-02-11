using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pictionnary.Forms
{
    public partial class GameEnd : Form
    {
        public GameEnd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the players
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public void ShowWinners(Player first, Player second, Player third)
        {
            lblFirstPlace.Text = $"{first.Name} :";
            lblFirstPoints.Text = $"{first.Points.ToString()} pts";
            lblFirstPodium.Text = first.Name;

            lblSecondPlace.Text = $"{second.Name} :";
            lblSecondPoints.Text = $"{second.Points.ToString()} pts";
            lblSecondPodium.Text = second.Name;

            lblThirdPlace.Text = $"{third.Name} :";
            lblThirdPoints.Text = $"{third.Points.ToString()} pts";
            lblThirdPodium.Text = third.Name;
        }
    }
}
