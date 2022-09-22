namespace WebSocketServerTest
{
    partial class ADCoreCommandServerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.NameOfPortInput = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.IPAddressInput = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.PortOfInput = new Sunny.UI.UITextBox();
            this.StartBtn = new Sunny.UI.UIButton();
            this.CloseBtn = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.IpListBox = new System.Windows.Forms.ListBox();
            this.LogDataListRecieve = new System.Windows.Forms.RichTextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.SendMessageData = new Sunny.UI.UIRichTextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(12, 32);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(83, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "主机名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // NameOfPortInput
            // 
            this.NameOfPortInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameOfPortInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameOfPortInput.Location = new System.Drawing.Point(118, 26);
            this.NameOfPortInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameOfPortInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.NameOfPortInput.Name = "NameOfPortInput";
            this.NameOfPortInput.ReadOnly = true;
            this.NameOfPortInput.ShowText = false;
            this.NameOfPortInput.Size = new System.Drawing.Size(150, 29);
            this.NameOfPortInput.TabIndex = 1;
            this.NameOfPortInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameOfPortInput.Watermark = "";
            this.NameOfPortInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(12, 68);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(79, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "主机IP:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IPAddressInput
            // 
            this.IPAddressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPAddressInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPAddressInput.Location = new System.Drawing.Point(118, 62);
            this.IPAddressInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPAddressInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.IPAddressInput.Name = "IPAddressInput";
            this.IPAddressInput.ReadOnly = true;
            this.IPAddressInput.ShowText = false;
            this.IPAddressInput.Size = new System.Drawing.Size(150, 29);
            this.IPAddressInput.TabIndex = 3;
            this.IPAddressInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPAddressInput.Watermark = "";
            this.IPAddressInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(12, 112);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(99, 23);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "主机端口：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PortOfInput
            // 
            this.PortOfInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PortOfInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortOfInput.Location = new System.Drawing.Point(118, 105);
            this.PortOfInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortOfInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.PortOfInput.Name = "PortOfInput";
            this.PortOfInput.ShowText = false;
            this.PortOfInput.Size = new System.Drawing.Size(150, 29);
            this.PortOfInput.TabIndex = 5;
            this.PortOfInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PortOfInput.Watermark = "";
            this.PortOfInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // StartBtn
            // 
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartBtn.Location = new System.Drawing.Point(16, 161);
            this.StartBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(95, 35);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "开启";
            this.StartBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.StartBtn.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseBtn.Location = new System.Drawing.Point(168, 161);
            this.CloseBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(100, 35);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "取消";
            this.CloseBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CloseBtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(12, 218);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(115, 23);
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.Text = "客户端列表：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(288, 17);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(145, 23);
            this.uiLabel5.TabIndex = 11;
            this.uiLabel5.Text = "接收的日志信息：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IpListBox
            // 
            this.IpListBox.FormattingEnabled = true;
            this.IpListBox.ItemHeight = 12;
            this.IpListBox.Location = new System.Drawing.Point(12, 249);
            this.IpListBox.Name = "IpListBox";
            this.IpListBox.Size = new System.Drawing.Size(269, 400);
            this.IpListBox.TabIndex = 12;
            // 
            // LogDataListRecieve
            // 
            this.LogDataListRecieve.Location = new System.Drawing.Point(292, 53);
            this.LogDataListRecieve.Name = "LogDataListRecieve";
            this.LogDataListRecieve.Size = new System.Drawing.Size(894, 280);
            this.LogDataListRecieve.TabIndex = 13;
            this.LogDataListRecieve.Text = "";
            this.LogDataListRecieve.TabIndexChanged += new System.EventHandler(this.LogDataList_TextChange);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(292, 340);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(173, 23);
            this.uiLabel6.TabIndex = 14;
            this.uiLabel6.Text = "发送的日志信息：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SendMessageData
            // 
            this.SendMessageData.FillColor = System.Drawing.Color.White;
            this.SendMessageData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendMessageData.Location = new System.Drawing.Point(296, 382);
            this.SendMessageData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendMessageData.MinimumSize = new System.Drawing.Size(1, 1);
            this.SendMessageData.Name = "SendMessageData";
            this.SendMessageData.Padding = new System.Windows.Forms.Padding(2);
            this.SendMessageData.ShowText = false;
            this.SendMessageData.Size = new System.Drawing.Size(903, 265);
            this.SendMessageData.Style = Sunny.UI.UIStyle.Custom;
            this.SendMessageData.TabIndex = 15;
            this.SendMessageData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendMessageData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ADCoreCommandServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 649);
            this.Controls.Add(this.SendMessageData);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.LogDataListRecieve);
            this.Controls.Add(this.IpListBox);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.PortOfInput);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.IPAddressInput);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.NameOfPortInput);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ADCoreCommandServerWindow";
            this.Text = "ADCoreServer";
            this.Load += new System.EventHandler(this.ADCoreCommandServerWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox NameOfPortInput;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox IPAddressInput;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox PortOfInput;
        private Sunny.UI.UIButton StartBtn;
        private Sunny.UI.UIButton CloseBtn;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private System.Windows.Forms.ListBox IpListBox;
        private System.Windows.Forms.RichTextBox LogDataListRecieve;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIRichTextBox SendMessageData;
    }
}