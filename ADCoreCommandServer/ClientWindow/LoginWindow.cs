using ADCommand.ClientWindowSys;
using ADCoreCommandCom;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCommandServer.ClientWindow
{
    public partial class LoginWindow : Form
    {
        ClientWindowSys.ClientSettingWindowSys settingWindowSys = new ClientWindowSys.ClientSettingWindowSys();
        LoginSys loginSys = new LoginSys(); 
        public LoginWindow()
        {
            InitializeComponent();
        }
        string userName;

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            settingWindowSys.StartGame();
        }

        private void AdminToggle_CheckedChanged(object sender, EventArgs e)
        {
            userName = "admin";
            SetAccountText(userName);
        }

        private void SetAccountText(string s)
        {
            AccountInput.Text = s;
        }

        private void UserToggle_CheckedChanged(object sender, EventArgs e)
        {
            userName = "user";
            SetAccountText(userName);
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(ClientWindow.IsConnection==false)
            {
                MessageBox.Show("请点击设置按钮转到服务器页面，连接服务器！！");
                return;
            }
            else
            {
                string account = AccountInput.Text.Trim();
                string password  = PasswordInput.Text.Trim();
                loginSys.ReqLogin(account, password);
                 
            }
        }
    }
}
