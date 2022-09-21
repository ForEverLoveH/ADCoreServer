using ADCommandServer.ClientWindow;
using ADCoreCommandCom;
using ADCoreCommandCom.SendData;
using Newtonsoft.Json;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCommandServer.ClientWindowSys
{
     public  class MainSys
     {

        public static MainSys Instance;
        MainWindow mainWindow;
        ClientSettingWindowSys clientSettingWindowSys= new ClientSettingWindowSys();
        private int sqlNumber;
        public  void Awake()
        {
            Instance = this;    
        }
        public void SendMessageToServer(string s)
        {
            clientSettingWindowSys.SendMessageToServer(s);
        }
       

         
        private void StartGame( bool  IsActive=true)
        {
            if (IsActive)
            {
                if (mainWindow == null)
                {
                    mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
                }
                else
                {
                    if (mainWindow.IsDisposed)
                    {
                        mainWindow = new MainWindow();
                        mainWindow.ShowDialog();

                    }
                    else
                    {
                        mainWindow.Activate();
                    }
                }
            }
            else
            {
                if (mainWindow != null)
                {
                    mainWindow.Dispose();
                }
            }
        }
        public void Init()
        {
            StartGame();
        }
        public void Req_GetKey()
        {

            ClientDataType dataType = new ClientDataType()
            {
                dataMsg = new DataMsg()
                {
                    req_GetKey = new Req_GetKeyByNewImport(),
                },
            };
            var s = JsonConvert.SerializeObject(new ClientSendDataToServer(dataType, ClientDataName.Req_GetKey));
            SendMessageToServer(s);

        }

        public  void Rsp_GetKeyByNewImport(ServerSendDataMessageToClient s)
        {
            if(s.errorType == ErrorType.NoDataMessageInSql)
            {
                 
                if (string.IsNullOrEmpty(s.serverdataType.Rsp_GetKey.num))
                {
                    string sl = "人员数据：0 条" ;
                    mainWindow.SetPersonTitleTxt(sl);
                }
                else
                {
                    string   num = $"人员数据:{s.serverdataType.Rsp_GetKey.num}条";
                    mainWindow.SetPersonTitleTxt(num);
                    int.TryParse(s.serverdataType.Rsp_GetKey.num, out sqlNumber);
                }
            }
             
        }
    }

}
