///ETML
///Auteur : lopezes
///Date : 11.02.2019
///Description : Allows to change of Form and hide the form where we are actually
using System.Windows.Forms;
using Pictionnary.Other;

namespace Pictionnary.Forms
{
    public class ChangeForm
    {
        /// <summary>
        /// Allows to change of form and hide the actual one
        /// </summary>
        /// <param name="actualForm">Form where we are</param>
        /// <param name="formToGo">Form that we want to show</param>
        public void ChangeOfForm(Form actualForm, DifferentForms formToGo )
        {
            //Switch that allows to know  which form we have to show
            switch(formToGo)
            {
                //Show the HomeView From
                case DifferentForms.Home:
                    HomeView home = new HomeView();
                    home.Show();
                    break;

                //Show the CreateRoomView From
                case DifferentForms.CreateGame:
                    CreateRoomView createRoomView = new CreateRoomView();
                    createRoomView.Show();
                    break;

                //Show the JoinRoomView From
                case DifferentForms.JoinGame:
                    JoinRoomView joinRoomView = new JoinRoomView();
                    joinRoomView.Show();
                    break;

                //Show the GameView From
                case DifferentForms.Game:
                    GameView game = new GameView();
                    game.Show();
                    break;

                //Show the GameEnd From
                case DifferentForms.EndGame:
                    GameEnd gameEnd = new GameEnd();
                    gameEnd.Show();
                    break;



            }

            //Hides the form where we are
            actualForm.Hide();

        }




    }

}
