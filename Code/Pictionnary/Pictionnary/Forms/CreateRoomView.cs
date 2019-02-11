///ETML
///Auteur : lopezes
///Date : 04.02.2019
///Description : Allows to have a checkComboBox, to change of form and get the params of a room
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Pictionnary.Forms
{
    public partial class CreateRoomView : Form
    {

        private List<string> listOfThemes;

        private List<string> checkedThemes;

        private List<string> paramsOfRoom;

        private List<string> listCHeckComboBoxTheme;

        private ChangeForm changeOfForm;


        /// <summary>
        /// Constructor
        /// </summary>
        public CreateRoomView()
        {
            listOfThemes = new List<string>();
            checkedThemes = new List<string>();
            paramsOfRoom = new List<string>();
            listCHeckComboBoxTheme = new List<string>();
            changeOfForm = new ChangeForm();


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
            //Icon = Pictionnary.Properties.Resources.Icon;



            chkcomboboxThemes.SetItems(listCHeckComboBoxTheme);
        }

        /// <summary>
        /// Allows to get the params of the room and change of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            checkedThemes = chkcomboboxThemes.CheckedItems;
            AddParamsOfRoom();

            Networking.NetworkingHelper.GetInstance().SetLocalRoom(new GameClasses.Room() { Password = txtBoxRoomPassword.Text });

            MessageBox.Show("IP locale : " + Networking.NetworkingHelper.GetInstance().GetLocalAdress());

            changeOfForm.ChangeOfForm(this, Other.DifferentForms.Game);
        }

        /// <summary>
        /// Allows to save the params of the room
        /// </summary>
        /// <returns>List with the params of the room</returns>
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
