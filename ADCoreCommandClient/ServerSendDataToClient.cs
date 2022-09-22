using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoreCommandCom.SendData
{
    public  class ServerSendDataToClient
    {
        public  ErrorType errorType { get; set; }
        public ServerDataName serverDataName { get; set; }
        public ServerDataType serverdataType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorType"></param>
        /// <param name="serverdataType"></param>
        public ServerSendDataToClient(ErrorType errorTypes, ServerDataType serverdataTypes , ServerDataName serverDataNames )
        {
            errorType = errorTypes;
            serverDataName = serverDataNames;
            serverdataType = serverdataTypes;
        }
        public ServerSendDataToClient()
        {

        }
    }

     

    /// <summary>
    ///  数据类型
    /// </summary>
    public class ServerDataType
    {
         public  RspLogin rsp_Login { get; set; }
        public Rsp_GetKey Rsp_GetKey { get; set; }

    }

    public class RspLogin
    {
        public PlayerDatas playerData { get; set; }
    }

    public class PlayerDatas
    {
        public  int IsLogin { get; set; }   
    }
}
