using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_SelonMaquettes
{
    public class Room
    {
        private string ipOfRoom;
        private string passwordOfRoom;

        public Room(string ip, string password)
        {
            ipOfRoom = ip;
            passwordOfRoom = password;

        }

        public void TestPassword(Form actualForm,string password)
        {
            if(password == passwordOfRoom)
            {
                ChangeForm change = new ChangeForm();

                change.ChangeOfForm(actualForm, Forms.game);

            }
            else
            {
                MessageBox.Show("Mot de passe erroné");
            }

        }

    }
}
