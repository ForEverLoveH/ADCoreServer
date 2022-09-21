namespace ADCommandServer.ClientWindow
{
    partial class LoginWindow
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
            this.AccountInput = new Sunny.UI.UITextBox();
            this.PasswordInput = new Sunny.UI.UITextBox();
            this.AdminToggle = new Sunny.UI.UICheckBox();
            this.UserToggle = new Sunny.UI.UICheckBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.SettingBtn = new Sunny.UI.UIButton();
            this.DelectBtn = new Sunny.UI.UIButton();
            this.LoginBtn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // AccountInput
            // 
            this.AccountInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.AccountInput.Location = new System.Drawing.Point(270, 90);
            this.AccountInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.AccountInput.Name = "AccountInput";
            this.AccountInput.ShowText = false;
            this.AccountInput.Size = new System.Drawing.Size(256, 29);
            this.AccountInput.TabIndex = 2;
            this.AccountInput.Text = " ";
            this.AccountInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountInput.Watermark = "";
            this.AccountInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.PasswordInput.Location = new System.Drawing.Point(270, 153);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.ShowText = false;
            this.PasswordInput.Size = new System.Drawing.Size(256, 29);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.Text = " ";
            this.PasswordInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasswordInput.Watermark = "";
            this.PasswordInput.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AdminToggle
            // 
            this.AdminToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminToggle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.AdminToggle.Location = new System.Drawing.Point(192, 223);
            this.AdminToggle.MinimumSize = new System.Drawing.Size(1, 1);
            this.AdminToggle.Name = "AdminToggle";
            this.AdminToggle.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.AdminToggle.Size = new System.Drawing.Size(150, 29);
            this.AdminToggle.TabIndex = 4;
            this.AdminToggle.Text = "管理员";
            this.AdminToggle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.AdminToggle.CheckedChanged += new System.EventHandler(this.AdminToggle_CheckedChanged);
            // 
            // UserToggle
            // 
            this.UserToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserToggle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.UserToggle.Location = new System.Drawing.Point(434, 223);
            this.UserToggle.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserToggle.Name = "UserToggle";
            this.UserToggle.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.UserToggle.Size = new System.Drawing.Size(150, 29);
            this.UserToggle.TabIndex = 5;
            this.UserToggle.Text = "裁判员";
            this.UserToggle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.UserToggle.CheckedChanged += new System.EventHandler(this.UserToggle_CheckedChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel1.Location = new System.Drawing.Point(163, 90);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 29);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "账号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel2.Location = new System.Drawing.Point(163, 153);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 29);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "密码：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.SettingBtn.Location = new System.Drawing.Point(704, 12);
            this.SettingBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(84, 35);
            this.SettingBtn.TabIndex = 8;
            this.SettingBtn.Text = "设置";
            this.SettingBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.SettingBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // DelectBtn
            // 
            this.DelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelectBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.DelectBtn.Location = new System.Drawing.Point(426, 301);
            this.DelectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.DelectBtn.Name = "DelectBtn";
            this.DelectBtn.Size = new System.Drawing.Size(100, 35);
            this.DelectBtn.TabIndex = 9;
            this.DelectBtn.Text = "取消";
            this.DelectBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.DelectBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.LoginBtn.Location = new System.Drawing.Point(177, 301);
            this.LoginBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(100, 35);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "登录";
            this.LoginBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.LoginBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.DelectBtn);
            this.Controls.Add(this.SettingBtn);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.UserToggle);
            this.Controls.Add(this.AdminToggle);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.AccountInput);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UITextBox AccountInput;
        private Sunny.UI.UICheckBox AdminToggle;
        private Sunny.UI.UIButton DelectBtn;
        private Sunny.UI.UIButton LoginBtn;
        private Sunny.UI.UITextBox PasswordInput;
        private Sunny.UI.UIButton SettingBtn;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UICheckBox UserToggle;

        #endregion
    }
}