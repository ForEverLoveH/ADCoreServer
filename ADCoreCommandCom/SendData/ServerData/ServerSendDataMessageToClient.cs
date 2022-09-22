using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoreCommandCom.SendData
{
    public  class ServerSendDataMessageToClient
    {
        public  ErrorType errorType { get; set; }
        public ServerDataName serverDataName { get; set; }
        public ServerDataMessageType serverdataType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorType"></param>
        /// <param name="serverdataType"></param>
        public ServerSendDataMessageToClient(ErrorType errorTypes, ServerDataMessageType serverdataTypes , ServerDataName serverDataNames )
        {
            errorType = errorTypes;
            serverDataName = serverDataNames;
            serverdataType = serverdataTypes;
        }
        public ServerSendDataMessageToClient()
        {

        }
    }

     

    /// <summary>
    ///  数据类型
    /// </summary>
    public class ServerDataMessageType
    {
         public  Rsp_Login rsp_Login { get; set; }
         public  Rsp_GetKey Rsp_GetKey { get; set; }

    }

    public class Rsp_Login
    {
        public PlayerData playerData { get; set; }
    }

    public class PlayerData
    {
        public  int IsLogin { get; set; }   
    }
}
