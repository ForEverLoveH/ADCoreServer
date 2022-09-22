using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoreCommandCom
{
    /// <summary>
    ///  发送的数据类型
    /// </summary>
    public  class ClientSendDataToServer
    {
        /// <summary>
        ///  消息类型
        /// </summary>
        public   ClientDataType dataType { get; set; }
        /// <summary>
        ///  消息名字
        /// </summary>
        public  ClientDataName ClientdataName { get; set; }
        
        public ClientSendDataToServer(ClientDataType dty , ClientDataName name)
        {
            dataType = dty;
            ClientdataName = name;    

        }
        public ClientSendDataToServer()
        {

        }
    }
    /// <summary>
    /// 
    /// </summary>
    public enum ClientDataName
    {
        None ,
        Login,
        Req_GetKey

    }
    /// <summary>
    /// 
    /// </summary>
    public class ClientDataType
    {
        public DataMsg dataMsg { get; set; }
    }

    public class DataMsg
    {
        public  Req_Login req_Login { get; set; }
        public  Req_GetKeyByNewImport req_GetKey { get; set; }

    }
}
