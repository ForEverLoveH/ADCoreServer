﻿using ADCoreCommandCom.GameConst;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoreCommandClient.ServerSQLDb
{
    public  class LoginSql
    {
        public static LoginSql Instance;
        public void Awake()
        {
            Instance = this;
        }
        /// <summary>
        ///  是否存在admin 表
        /// </summary>
        /// <param name="Name"></param>
        public void IsExtenceAdminData(string name)
        {

            string path = Application.StartupPath + GameConst.UserDBPath;
            SqliteCommandDB    sql = new SqliteCommandDB(path);
            int isExistenceAdminData = sql.IsCreateTable(name);
            if (isExistenceAdminData == 0)
            {
                Console.WriteLine($"数据库表{name}不存在");
                sql.CreateTable<AdminModel>(name);

                //初始化Admin表
                Admin admin = new Admin() { User = GameConst.InitAdminAcct, Password = GameConst.InitAdminPass };
                Admin user = new Admin() { User = GameConst.InitUserAcct, Password = GameConst.InitUserPass };
                List<Admin> admins = new List<Admin>();
                admins.Add(admin);
                admins.Add(user);
                sql.Insert<Admin>(admins, name);
            }
            if (isExistenceAdminData == 1)
            {
                Console.WriteLine($"数据库表{name}存在");
            }
            sql.Dispose();
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="Name">数据库的名字</param>
        /// <param name="acc">账号信息</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsLogin(string Name, string acc, string password)
        {
            try
            {
                string path = Application.StartupPath + GameConst.UserDBPath;
                SqliteCommandDB sql = new  SqliteCommandDB(path);
                var UserAdmin = sql.SelectBySql<Admin>(Name, $"User = '{acc}' and Password = '{password}'");
                if (UserAdmin.Count == 1)
                {
                    sql.Dispose();
                    return true;
                }
                else if (UserAdmin.Count > 1)
                {
                    sql.Dispose();
                    Console.WriteLine($"数据库已被非法修改");
                    return false;
                }
                sql.Dispose();
                return false;
            }

            catch (Exception e)
            {
                Console.WriteLine("登录异常" + e.Message);
                return false;
            }

        }
    }
}

