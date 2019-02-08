using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_SelonMaquettes
{
    public partial class GameView : Form
    {
<<<<<<< HEAD
        Dictionary<string, int> PlayersPoints = new Dictionary<string, int>();
=======
       

>>>>>>> 514a462a78e1e6bb8fe5674da1f9d6a09040b5ba

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
