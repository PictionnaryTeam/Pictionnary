using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckComboBox;

namespace Prototype_SelonMaquettes
{
    public partial class CreateRoomView : Form
    {

        private List<string> listOfThemes;

        private List<string> checkedThemes;

        private List<string> paramsOfRoom;

        private List<string> listCHeckComboBoxTheme;



        public CreateRoomView()
        {
            listOfThemes = new List<string>();
            checkedThemes = new List<string>();
            paramsOfRoom = new List<string>();
            listCHeckComboBoxTheme = new List<string>();

            listCHeckComboBoxTheme.Add("Actions");
            listCHeckComboBoxTheme.Add("Aliments");
            listCHeckComboBoxTheme.Add("Animaux");
            listCHeckComboBoxTheme.Add("Biologie");
            listCHeckComboBoxTheme.Add("Informatique");
            listCHeckComboBoxTheme.Add("Jeux");
            listCHeckComboBoxTheme.Add("Lieux");
            listCHeckComboBoxTheme.Add("Minéraux");
            listCHeckComboBoxTheme.Add("Objets du quoitidien");
            listCHeckComboBoxTheme.Add("Personnages fictifs");
            listCHeckComboBoxTheme.Add("Personnages réels");
            listCHeckComboBoxTheme.Add("Sport");
           
            InitializeComponent();
            Icon = Prototype_SelonMaquettes.Properties.Resources.Icon;



            chkcomboboxThemes.SetItems(listCHeckComboBoxTheme);
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            checkedThemes = chkcomboboxThemes.CheckedItems;
            AddParamsOfRoom();

            GameView gameView = new GameView();
            gameView.Show();

            

            
            Hide();
        }

        public List<string> AddParamsOfRoom()
        {
            listOfThemes.Add(txtBoxRoomName.Text);
            listOfThemes.Add(txtBoxRoomPassword.Text);
            listOfThemes.Add(numUpDownLimitPlayers.Text);
            if(chkBoxGamesLimit.Checked)
            {
                listOfThemes.Add(numUpDownGamesLimit.Text);
            }
            

            foreach (string item in checkedThemes)
            {
                listOfThemes.Add(item);
            }

            listOfThemes.Add(cmbBoxGameDifficulty.Text);
            listOfThemes.Add(numUpDownTimeLimit.Text);

            if (chkBoxClues.Checked)
            {
                listOfThemes.Add(chkBoxClues.Text);
            }

            if (chkBoxBlind.Checked)
            {
                listOfThemes.Add(chkBoxBlind.Text);
            }

            if (chkBoxContinuedWrite.Checked)
            {
                listOfThemes.Add(chkBoxContinuedWrite.Text);
            }

            if (chkBoxInversedMouse.Checked)
            {
                listOfThemes.Add(chkBoxInversedMouse.Text);
            }
            return listOfThemes;
        }
    }
}
