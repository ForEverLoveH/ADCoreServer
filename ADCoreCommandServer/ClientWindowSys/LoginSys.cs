using ADCommandServer.ClientWindow;
using ADCommandServer.ClientWindowSys;
using ADCoreCommandCom;
using ADCoreCommandCom.SendData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCommand.ClientWindowSys
{
    public class LoginSys
    {
        public MainSys mainSys = new MainSys();
        public static LoginSys Instance;
        public ClientSettingWindowSys ClientSettingWindowSys = new ClientSettingWindowSys();
        // public bool main = false;
        LoginWindow loginWindow;
        public void Awake()
        {
            Instance = this;
        }

        public void Init()
        {
            StartGame();
        }
        public void StartGame(bool isActive = true)
        {
            if (isActive)
            {
                if (loginWindow == null)
                {
                    Application.Run(loginWindow = new LoginWindow());
                }
                else
                {
                    if (loginWindow.IsDisposed)
                    {
                        Application.Run(loginWindow = new LoginWindow());
                    }
                    else
                    {
                        loginWindow.Activate();
                    }
                }
            }
            else
            {
                if (loginWindow != null)
                {
                    loginWindow.Dispose();
                }
            }
        }

        public void SendMessageToServer(string s)
        {
            ClientSettingWindowSys.SendMessageToServer(s);
        }

        public  void Rsp_Login(ServerSendDataMessageToClient s)
        {
            if (s.errorType == ErrorType.LoginAccountPasswordIsOnline)
            {
                MessageBox.Show("账号信息不完整。请填写完整");
                return;
            }
            else
            {
                if(s.serverdataType.rsp_Login.playerData.IsLogin == 0)
                {
                    MessageBox.Show("登录成功!!");
                    MainSys.Instance.Init();
                }
                else if(s.serverdataType.rsp_Login.playerData.IsLogin == 1)
                {
                    MessageBox.Show("登录失败，请核查账号信息！！");
                    return;
                }
            }
        }

        public  void ReqLogin(string account, string password)
        {
            if (!string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(password))
            {
                ClientDataType data = new ClientDataType()
                {
                    dataMsg = new DataMsg()
                    {
                        req_Login = new Req_Login()
                        {
                            account = account,
                            pass = password,
                        }
                    }
                };
                var s = JsonConvert.SerializeObject(new ClientSendDataToServer(data, ClientDataName.Login));
                SendMessageToServer(s);

            }
        }
    }
        
}
