using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionnary.GameClasses
{
    class ScoreManager
    {
        private static ScoreManager _instance;


        private ScoreManager()
        {

        }

        public static ScoreManager GetInstance()
        {
            if (_instance == null)
                _instance = new ScoreManager();


            return _instance;
        }


        public void PlayerFoundWord(string playerName, DateTime time)
        {

        }
    }
}
