using ADCoreCommandClient.ServerSQLDb;
using ADCoreCommandClient.ServerSQLDb.NewImport;
using ADCoreCommandClient.SQLite;
using ADCoreCommandClient.WindowSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADCoreCommandClient
{
    public  class ADCoreCommandServerRoot
    {
        static SqliteDB sqliteDB = new SqliteDB();
        static  LoginSql LoginSql = new LoginSql();
        static  NewImportSql NewImportSql = new NewImportSql();
        static ADCoreServerWindowSys ADCoreServerWindowSys = new ADCoreServerWindowSys();
        public  static  void  ADCoreCommandServerGameStart()
        {
            Awake();
            Start();

        }

        private static void Start()
        {
             sqliteDB.Init();
             ADCoreServerWindowSys.Init();   


        }

        private static void Awake()
        {
            sqliteDB.Awake();
            LoginSql.Awake();
            NewImportSql.Awake();
        }
    }
}
