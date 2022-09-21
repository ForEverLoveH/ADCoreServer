using System;
using System.Windows.Forms;

namespace ADCommandServer.ClientWindow
{
    partial class FrmLoading
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
            this.PnlImage = new Sunny.UI.UIPanel();
            this.LblMessage = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // PnlImage
            // 
            this.PnlImage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PnlImage.Location = new System.Drawing.Point(0, 4);
            this.PnlImage.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.PnlImage.MinimumSize = new System.Drawing.Size(2, 2);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Size = new System.Drawing.Size(1340, 760);
            this.PnlImage.TabIndex = 0;
            this.PnlImage.Text = null;
            this.PnlImage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PnlImage.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LblMessage
            // 
            this.LblMessage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblMessage.Location = new System.Drawing.Point(320, 541);
            this.LblMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(440, 93);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "正在处理中请稍后...";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblMessage.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1333, 788);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.PnlImage);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "FrmLoading";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLoading";
            this.ResumeLayout(false);

        }

        

        #endregion

        private Sunny.UI.UIPanel PnlImage;
        private Sunny.UI.UILabel LblMessage;
    }
}