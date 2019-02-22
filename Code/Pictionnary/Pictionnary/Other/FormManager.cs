using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pictionnary.Forms;

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

        public static void InitializeForms()
        {
            createRoomView = new CreateRoomView();
            gameEnd = new GameEnd();
            gameView = new GameView();
            homeView = new HomeView();
            joinRoomView = new JoinRoomView();
            roundEnd = new RoundEnd();
        }
    }
}
