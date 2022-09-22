using ADCoreCommandClient.SQLite;
using ADCoreCommandCom;
using ADCoreCommandCom.GameConst;
using ADCoreCommandCom.SendData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketServerTest;

namespace ADCoreCommandClient.WindowSys
{
    public  class ADCoreServerWindowSys
    {
        public static ADCoreCommandServerWindow ADCoreCommandServerWindow;

        public  void Init()
        {
            StartGame();
        }

         

        private  void StartGame(bool isActive = true)
        {
            if (isActive)
            {
                if (ADCoreCommandServerWindow == null)
                {
                    Application.Run(ADCoreCommandServerWindow = new ADCoreCommandServerWindow());
                }
                else
                {
                    if (ADCoreCommandServerWindow.IsDisposed)
                    {
                        Application.Run(ADCoreCommandServerWindow = new ADCoreCommandServerWindow());
                    }
                    else
                    {
                        ADCoreCommandServerWindow.Activate();
                    }
                }
            }
            else
            {
                if (ADCoreCommandServerWindow != null)
                {
                    ADCoreCommandServerWindow.Dispose();
                }
            }
        }
        /// <summary>
        /// 处理发送客户端到服务器的信息
        /// </summary>
        /// <param name="sendData"></param>
        public  void HandleMessage(ClientSendDataToServer sendData)
        {
            switch (sendData.ClientdataName)
            {
                case ClientDataName.Login:
                    var data = sendData.dataType.dataMsg.req_Login;
                    SqliteDB.Instance.ReqLogin(data);
                    break;
                case ClientDataName.Req_GetKey:
                    var datas = sendData.dataType.dataMsg.req_GetKey;
                    SqliteDB.Instance.Req_GetKeyByNewImport(GameConst.DBUserExcel,"Id");
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverSendDataToClient"></param>
        public  void SendDataToClient(ServerSendDataToClient serverSendDataToClient)
        {
            var msg = JsonConvert.SerializeObject(new ServerSendDataToClient(serverSendDataToClient.errorType, serverSendDataToClient.serverdataType, serverSendDataToClient.serverDataName));
            ADCoreCommandServerWindow.SendMessage(msg); 
        }
    }
}
