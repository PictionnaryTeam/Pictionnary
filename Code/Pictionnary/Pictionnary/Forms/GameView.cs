﻿using System;
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
    public partial class GameView : Form
    {
        Dictionary<string, int> PlayersPoints = new Dictionary<string, int>();

        public GameView()
        {
            InitializeComponent();

            List<string> listOfParams = new List<string>();

            foreach (string element in listOfParams)
            {
                MessageBox.Show(element);
            }
        }

    


    }
}
