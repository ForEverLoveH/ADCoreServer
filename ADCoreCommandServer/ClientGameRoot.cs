
using ADCommand.ClientWindowSys;
using ADCommandServer.ClientWindowSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCommandServer
{
    public class ClientGameRoot
    {
        private static LoginSys loginSys  = new LoginSys ();
        static MainSys mainSys = new MainSys();
        public  static void StartClientGame()
        {
            Awake();

            Start();

        }

        private static void Start()
        {
            loginSys.StartGame();
        }

        private  static  void Awake()
        {
            loginSys.Awake();
            mainSys.Awake();



        }
    }
}
