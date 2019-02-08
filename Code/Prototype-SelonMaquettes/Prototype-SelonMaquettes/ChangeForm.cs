using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_SelonMaquettes
{
    class ChangeForm
    {

        public void ChangeOfForm(Form actualForm, Forms formToGo)
        {
            switch(formToGo)
            {
                case Forms.accueil:
                    HomeView home = new HomeView();
                    home.Show();
                    break;

                case Forms.createRoom:
                    CreateRoomView createRoom = new CreateRoomView();
                    createRoom.Show();
                    break;

                case Forms.enterRoom:
                    JoinRoomView joinRoom = new JoinRoomView();
                    joinRoom.Show();
                    break;

                case Forms.game:
                    GameView game = new GameView();
                    game.Show();
                    break;
            }

            actualForm.Hide();

        }




    }
}
