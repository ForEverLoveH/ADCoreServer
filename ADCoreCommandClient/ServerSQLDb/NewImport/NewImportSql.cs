using ADCoreCommandClient.Model;
using ADCoreCommandCom.GameConst;
using ADCoreCommandCom.SendData;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ADCoreCommandClient.ServerSQLDb.NewImport
{
    public  class NewImportSql
    {
        public static NewImportSql Instance;

        public  void Awake()
        {
            Instance = this;    
        }

         

        public  string  Req_GetKeyByNewImport(string  name, string key)
        {
            IsExistenceUserExcelData(name);
            string dbPath = Application.StartupPath + GameConst .SaveDBPath;
             SqliteCommandDB sqliteCommandDB = new SqliteCommandDB(dbPath);
            object number = sqliteCommandDB.GetKey(name, key);
            sqliteCommandDB.Dispose();
            return number.ToString();
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        private void IsExistenceUserExcelData(string name)
        {
            try
            {
                string dbPath = Application.StartupPath + GameConst .SaveDBPath;
                SqliteCommandDB sqliteCommandDB = new SqliteCommandDB(dbPath);
                if (sqliteCommandDB.IsCreateTable(name) == 1)
                {
                    Console.WriteLine($"数据表{name}已存在！！");
                }
                if (sqliteCommandDB.IsCreateTable(name) == 0)
                {
                    Console.WriteLine($"数据库表{name}不存在");
                    sqliteCommandDB.CreateTable<UserExcelMode>(name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"数据表{name}查询异常" + e.Message);
            }
        }
    }
}
