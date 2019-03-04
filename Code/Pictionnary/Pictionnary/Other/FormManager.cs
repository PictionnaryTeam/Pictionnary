using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pictionnary.Forms;
using System.Windows.Forms;

namespace Pictionnary.Other
{
    public static class FormManager
    {
        public static CreateRoomView createRoomView;
        public static GameEnd gameEnd;
        public static GameView gameView;
        public static HomeView homeView;
        public static JoinRoomView joinRoomView;
        public static RoundEnd roundEnd;

        private static List<Form> _forms;

        public static void InitializeForms()
        {
            _forms = new List<Form>();

            createRoomView = new CreateRoomView();
            gameEnd = new GameEnd();
            gameView = new GameView();
            homeView = new HomeView();
            joinRoomView = new JoinRoomView();
            roundEnd = new RoundEnd();

            _forms.Add(createRoomView);
            _forms.Add(gameEnd);
            _forms.Add(gameView);
            _forms.Add(homeView);
            _forms.Add(joinRoomView);
            _forms.Add(roundEnd);

            foreach (Form form in _forms)
            {
                form.FormClosed += new FormClosedEventHandler((object sender, FormClosedEventArgs e) => { Environment.Exit(0); });
            }
        }
    }
}
