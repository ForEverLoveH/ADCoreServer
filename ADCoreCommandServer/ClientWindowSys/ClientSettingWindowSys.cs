using ADCommand.ClientWindowSys;
using ADCommandServer.ClientWindow;
using ADCoreCommandCom.SendData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCommandServer.ClientWindowSys
{
    public  class ClientSettingWindowSys
    {

        private  static ClientWindow.ClientWindow clientSettingWindow;

        public  void StartGame(bool IsActive= true )
        {
            if (IsActive)
            {
                if (clientSettingWindow == null)
                {
                    clientSettingWindow = new ClientWindow.ClientWindow();

                    clientSettingWindow.Show();
                }
                else
                {
                    if (clientSettingWindow.IsDisposed)
                    {
                        clientSettingWindow = new ClientWindow.ClientWindow();
                        clientSettingWindow.Show();
                    }
                    else
                    {
                        clientSettingWindow.Activate();
                    }
                }
            }
            else
            {
                if (clientSettingWindow != null)
                {
                    clientSettingWindow.Dispose();
                }
            }
        }

         public  void SendMessageToServer(string s)
         {
            clientSettingWindow.SendMessage(s);
         }

        public  void HandMessageToClient(ServerSendDataMessageToClient s)
        {
            switch (s.serverDataName)
            {
                case ServerDataName.Login:
                    LoginSys.Instance.Rsp_Login(s);
                    break;
                case ServerDataName.Rsp_GetKey:
                    MainSys.Instance.Rsp_GetKeyByNewImport(s);
                    break;
            }
        }
    }
}
