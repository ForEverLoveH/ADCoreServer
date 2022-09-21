namespace ADCommandServer.ClientWindow
{
    partial class ClientWindow
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
            this.NameOfComputerInput = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.IPAdressInput = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.PortOfComputerInput = new Sunny.UI.UITextBox();
            this.ConnectBtn = new Sunny.UI.UIButton();
            this.CloseBtn = new Sunny.UI.UIButton();
            this.LogData = new Sunny.UI.UILabel();
            this.SendmsgBox = new Sunny.UI.UIRichTextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.ReceMsgBox = new Sunny.UI.UIRichTextBox();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(17, 16);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(91, 29);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "主机名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // NameOfComputerInput
            // 
            this.NameOfComputerInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameOfComputerInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameOfComputerInput.Location = new System.Drawing.Point(111, 16);
            this.NameOfComputerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameOfComputerInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.NameOfComputerInput.Name = "NameOfComputerInput";
            this.NameOfComputerInput.ShowText = false;
            this.NameOfComputerInput.Size = new System.Drawing.Size(163, 29);
            this.NameOfComputerInput.TabIndex = 1;
            this.NameOfComputerInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameOfComputerInput.Watermark = "";
            this.NameOfComputerInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(17, 52);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(87, 29);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "主机IP:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IPAdressInput
            // 
            this.IPAdressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPAdressInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPAdressInput.Location = new System.Drawing.Point(111, 52);
            this.IPAdressInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPAdressInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.IPAdressInput.Name = "IPAdressInput";
            this.IPAdressInput.ShowText = false;
            this.IPAdressInput.Size = new System.Drawing.Size(163, 29);
            this.IPAdressInput.TabIndex = 3;
            this.IPAdressInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPAdressInput.Watermark = "";
            this.IPAdressInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(12, 101);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(102, 23);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "主机端口：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PortOfComputerInput
            // 
            this.PortOfComputerInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PortOfComputerInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PortOfComputerInput.Location = new System.Drawing.Point(111, 101);
            this.PortOfComputerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortOfComputerInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.PortOfComputerInput.Name = "PortOfComputerInput";
            this.PortOfComputerInput.ShowText = false;
            this.PortOfComputerInput.Size = new System.Drawing.Size(163, 29);
            this.PortOfComputerInput.TabIndex = 5;
            this.PortOfComputerInput.Text = " ";
            this.PortOfComputerInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PortOfComputerInput.Watermark = "";
            this.PortOfComputerInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectBtn.Location = new System.Drawing.Point(21, 156);
            this.ConnectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 35);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "连接";
            this.ConnectBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ConnectBtn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseBtn.Location = new System.Drawing.Point(174, 156);
            this.CloseBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(100, 35);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "断开";
            this.CloseBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CloseBtn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // LogData
            // 
            this.LogData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogData.Location = new System.Drawing.Point(316, 10);
            this.LogData.Name = "LogData";
            this.LogData.Size = new System.Drawing.Size(154, 23);
            this.LogData.TabIndex = 9;
            this.LogData.Text = "发送信息列表：";
            this.LogData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SendmsgBox
            // 
            this.SendmsgBox.FillColor = System.Drawing.Color.White;
            this.SendmsgBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendmsgBox.Location = new System.Drawing.Point(297, 52);
            this.SendmsgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendmsgBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SendmsgBox.Name = "SendmsgBox";
            this.SendmsgBox.Padding = new System.Windows.Forms.Padding(2);
            this.SendmsgBox.ShowText = false;
            this.SendmsgBox.Size = new System.Drawing.Size(924, 259);
            this.SendmsgBox.Style = Sunny.UI.UIStyle.Custom;
            this.SendmsgBox.TabIndex = 10;
            this.SendmsgBox.Text = " ";
            this.SendmsgBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendmsgBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(297, 320);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(173, 23);
            this.uiLabel4.TabIndex = 11;
            this.uiLabel4.Text = "接收信息列表";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ReceMsgBox
            // 
            this.ReceMsgBox.FillColor = System.Drawing.Color.White;
            this.ReceMsgBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReceMsgBox.Location = new System.Drawing.Point(297, 348);
            this.ReceMsgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReceMsgBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.ReceMsgBox.Name = "ReceMsgBox";
            this.ReceMsgBox.Padding = new System.Windows.Forms.Padding(2);
            this.ReceMsgBox.ShowText = false;
            this.ReceMsgBox.Size = new System.Drawing.Size(924, 237);
            this.ReceMsgBox.Style = Sunny.UI.UIStyle.Custom;
            this.ReceMsgBox.TabIndex = 12;
            this.ReceMsgBox.Text = " ";
            this.ReceMsgBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReceMsgBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 590);
            this.Controls.Add(this.ReceMsgBox);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.SendmsgBox);
            this.Controls.Add(this.LogData);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.PortOfComputerInput);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.IPAdressInput);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.NameOfComputerInput);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ClientWindow";
            this.Text = "ClientSettingWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox NameOfComputerInput;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox IPAdressInput;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox PortOfComputerInput;
        private Sunny.UI.UIButton ConnectBtn;
        private Sunny.UI.UIButton CloseBtn;
        private Sunny.UI.UILabel LogData;
        private Sunny.UI.UIRichTextBox SendmsgBox;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIRichTextBox ReceMsgBox;
    }
}