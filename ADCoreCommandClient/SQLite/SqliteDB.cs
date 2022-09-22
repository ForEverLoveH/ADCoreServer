using ADCoreCommandClient.ServerSQLDb;
using ADCoreCommandClient.ServerSQLDb.NewImport;
using ADCoreCommandClient.WindowSys;
using ADCoreCommandCom;
using ADCoreCommandCom.GameConst;
using ADCoreCommandCom.SendData;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoreCommandClient.SQLite
{
    public class SqliteDB
    {
        public static SqliteDB Instance;
        ADCoreServerWindowSys ADCoreServerWindowSys = new ADCoreServerWindowSys();

        public void Awake()
        {
            Instance = this;
        }
        private string DBpath = Application.StartupPath + GameConst.DBPath;


        /// <summary>
        ///  初始化
        /// </summary>
        public void Init()
        {
            if (!System.IO.Directory.Exists(DBpath))
            {
                System.IO.Directory.CreateDirectory(DBpath);
                Console.WriteLine($"数据库文件夹已丢失，已重新创建dataBase文件夹的路径为{DBpath}");
            }
            string dbPath = Application.StartupPath + GameConst.UserDBPath;
            if (File.Exists(dbPath))
            {
                Console.WriteLine("SaveData文件存在");
            }
            else
            {
                SqliteConnectionDB sql = new SqliteConnectionDB(dbPath);
                sql.Dispose();
            }
            string UserdbPath = Application.StartupPath + GameConst.SaveDBPath;
            if (File.Exists(UserdbPath))
            {
                Console.WriteLine($" {UserdbPath}文件存在");
            }
            else
            {
                Console.WriteLine($" {UserdbPath}文件不存在");
                SqliteConnectionDB sql = new SqliteConnectionDB(UserdbPath);
                sql.Dispose();
            }
            Export_database(dbPath, "Init");
        }
        private void Export_database(string ExportPath, string Cmd, bool IsExport = GameConst.IsExport)
        {
            if (IsExport)
            {
                try
                {
                    var dirName = new FileInfo(ExportPath).Directory.FullName;
                    dirName += "/ExportDatabase/";
                    if (!Directory.Exists(dirName))
                    {
                        Directory.CreateDirectory(dirName);
                    }
                    File.Copy(ExportPath, dirName + $"{DateTime.Now.ToString("yyyyMMdd-HH-mm-ss-ms")}_{Cmd}_backups.db", true);//拷贝文件 可以覆盖
                    if (File.Exists(dirName + $"{DateTime.Now.ToString("yyyyMMdd-HH-mm-ss-ms")}_{Cmd}_backups.db"))
                    {
                        Console.WriteLine("数据库文件备份成功,文件路径： " + dirName + $"{DateTime.Now.ToString("yyyyMMdd-HH-mm-ss-ms")}_{Cmd}_backups.db");
                    }

                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"备份数据库异常：{e.Message}");
                }
            }

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="data"></param>
        public void ReqLogin(ADCoreCommandCom.Req_Login data)
        {
            if (string.IsNullOrEmpty(data.account) || string.IsNullOrEmpty(data.pass))
            {
                ServerSendDataToClient serverSendDataToClient = new ServerSendDataToClient()
                {
                    errorType = ErrorType.LoginAccountPasswordIsOnline,
                    serverDataName  = ServerDataName.Login,
                    serverdataType = null,
                };
                // 调用服务器的发送
                ADCoreServerWindowSys.SendDataToClient(serverSendDataToClient);
            }
            else if (!string.IsNullOrEmpty(data.account) && !string.IsNullOrEmpty(data.pass))
            {
                LoginSql.Instance.IsExtenceAdminData(GameConst.DBLoginName);
                ADCoreCommandCom.SendData.ServerSendDataToClient serverSendDataToClient = new ServerSendDataToClient()
                {
                    errorType = ErrorType.None,
                    serverDataName = ServerDataName.Login,
                };
                if (LoginSql.Instance.IsLogin(GameConst.DBLoginName, data.account, data.pass))
                {
                    //登录成功
                    
                    serverSendDataToClient.serverdataType = new ServerDataType()
                    {
                        rsp_Login  = new RspLogin()
                        {
                             playerData = new PlayerDatas()
                             {
                                 IsLogin = 0,
                             }
                        }
                    };
                    ADCoreServerWindowSys.SendDataToClient(serverSendDataToClient);
                }
                else
                {
                    
                    serverSendDataToClient.serverdataType = new ServerDataType()
                    {
                        rsp_Login = new RspLogin()
                        {
                            playerData = new PlayerDatas()
                            {
                                IsLogin = -1,
                            }
                        }
                    };
                    ADCoreServerWindowSys.SendDataToClient(serverSendDataToClient);
                }

            }   

        }

        public void Req_GetKeyByNewImport(string dBUserExcel,string id)
        {
            string num =  NewImportSql.Instance.Req_GetKeyByNewImport(dBUserExcel ,id);
            if (string.IsNullOrEmpty(num))
            {
                ServerSendDataToClient serverSendDataToClient = new ServerSendDataToClient()
                {
                    errorType = ErrorType.NoDataMessageInSql,
                    serverDataName = ServerDataName.Rsp_GetKey,
                };
                ADCoreServerWindowSys.SendDataToClient(serverSendDataToClient);
            }
            else
            {
                ServerSendDataToClient serverSendDataToClient = new ServerSendDataToClient()
                {
                    errorType = ErrorType.None,
                    serverDataName = ServerDataName.Rsp_GetKey,
                    serverdataType = new ServerDataType()
                    {
                        Rsp_GetKey = new Rsp_GetKey
                        {
                            num = num,
                        }
                    },

                };
                ADCoreServerWindowSys.SendDataToClient(serverSendDataToClient);
            }

            

        }
    }

}
