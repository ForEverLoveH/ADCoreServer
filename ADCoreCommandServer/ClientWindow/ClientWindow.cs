using ADCommand.ClientWindowSys;
using ADCommandServer.ClientWindowSys;
using ADCoreCommandCom.SendData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using static System.Net.Mime.MediaTypeNames;

namespace ADCommandServer.ClientWindow
{
    public partial class ClientWindow : Form
    {
        public static bool IsConnection = false; 
        WebSocket ws;
        ClientSettingWindowSys ClientSettingWindowSys= new ClientSettingWindowSys();    
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void ClientSettingWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(this.NameOfComputerInput.Text) && string.IsNullOrEmpty(this.IPAdressInput.Text)) || string.IsNullOrEmpty(this.PortOfComputerInput.Text))
            {
                MessageBox.Show("基本信息不能为空!", "错误");
                IsConnection = false;
                return;
            }
            IPAddress[] addressList = Dns.GetHostEntry(this.NameOfComputerInput.Text.ToString()).AddressList;
            string ipStr = "";
            foreach (var address in addressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipStr = address.ToString();
                }
            }
            this.IPAdressInput.Text = ipStr;
            try
            {
                ws = new WebSocket(string.Format("ws://{0}:{1}", ipStr, this.PortOfComputerInput.Text.ToString().Trim()));

            }
            catch (SocketException ex)
            {
                this.SendmsgBox.Text += formatMessage(this.NameOfComputerInput.Text, "连接错误,请查看弹窗信息。");
                IsConnection = false;
                MessageBox.Show("错误:\n" + ex.ToString());
                return;

            }
            try
            {
                ws.Connect();
                this.SendmsgBox.Text += formatMessage(this.NameOfComputerInput.Text, "连接成功！！。"  );
                IsConnection=true;  
                this.changeStuta(false);
            }
            catch (SocketException ex)
            {
                this.SendmsgBox.Text += formatMessage(this.NameOfComputerInput.Text, "连接失败,请查看弹窗信息。" + ex.Message.ToString());
                 IsConnection = false;    
                MessageBox.Show("错误:\n" + ex.ToString());
                return;
            }
            ws.OnOpen += Ws_OnOpen;

            ws.OnMessage += Ws_OnMessage;

            ws.OnClose += Ws_OnClose;

            ws.OnError += Ws_OnError;
            ConnectBtn.Enabled = false; 
        }

        private void Ws_OnError(object sender, ErrorEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                MessageBox.Show("服务器断开连接!");
                this.changeStuta(false);
            }));
        }

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            try
            {
                ws.Close();
                this.changeStuta(true);
                ConnectBtn.Enabled = true;
                IsConnection=false;
                SendmsgBox.Clear();
                ReceMsgBox.Clear();
            }
            catch (Exception ex)
            {
                this.SendmsgBox.Text += formatMessage(this.NameOfComputerInput.Text, "连接错误,请查看弹窗信息。");
                MessageBox.Show("错误:\n" + ex.ToString());
                return;

            }


        }
        //WebSocket 连接时发生事件
        private void Ws_OnOpen(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                this.changeStuta(false);
            }));
        }
        // WebSocket 连接关闭时发生事件
        private void Ws_OnClose(object sender, CloseEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                this.changeStuta(false);
            }));

        }
        //当接收到消息时发生事件
        private   void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                this.ReceMsgBox.Text += formatMessage(this.NameOfComputerInput.Text, e.Data);
            }));
                
            RecieveDataFromServer(e.Data);
          
        }
        /// <summary>
        /// 收到来自服务器的信息的处理
        /// </summary>
        /// <param name="data"></param>
        private void RecieveDataFromServer(string data)
        {
            var s = JsonConvert.DeserializeObject<ServerSendDataMessageToClient>(data);
            ClientSettingWindowSys.HandMessageToClient(s);
        }


        /// <summary>
        /// 改变状态
        /// </summary>
        /// <param name="close">true为关闭,false为开启</param>
        private void changeStuta(bool close)
        {
            
            this.NameOfComputerInput.ReadOnly = !close;
            this.IPAdressInput.ReadOnly = !close;
            this.PortOfComputerInput.ReadOnly = !close;
        }


        /// <summary>
        /// 格式化信息栏显示的信息
        /// </summary>
        /// <param name="from">发送人</param>
        /// <param name="msg">信息</param>
        /// <param name="isSend">判断为接收还是发送</param>
        /// <param name="to">接收人</param>
        /// <returns></returns>       
        private string formatMessage(string from, string msg, bool isSend = false, string to = null)
        {
            return string.Format("{2}\t{3}{4}{0}的信息:\n{1}\n", !isSend ? from : "", msg, DateTime.Now.ToString("yyyy-MM-dd HH:ss:dd"), !isSend ? "来自" : "发送给", to);
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="msg"></param>
        public  void SendMessage(string msg)
        {
            try
            {
                ws.Send(msg);
                this.Invoke(new MethodInvoker(delegate
                {
                    this.SendmsgBox.Text += formatMessage(null, msg, true, IPAdressInput.Text);
                }));     
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.SendmsgBox.Text += formatMessage(this.NameOfComputerInput.Text, "连接错误,请查看弹窗信息。");
                    MessageBox.Show("错误：\n" + ex.Message);
                    return;
                }));
            }

        }    
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCloseConn_Click(sender, e);
        }
        //消息文本框始终保持在最下面
        private void msgBox_TextChanged(object sender, EventArgs e)
        {
            SendmsgBox.SelectionStart = SendmsgBox.Text.Length;
            SendmsgBox.ScrollToCaret();
        }
    }
}
  