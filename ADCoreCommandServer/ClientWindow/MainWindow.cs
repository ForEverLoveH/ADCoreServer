using ADCommandServer.ClientWindowSys;
using ADCommandServer.LocalFile;
using ADCoreCommandCom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCommandServer.ClientWindow
{
    public partial class MainWindow : Form
    {
        MainSys mainSys = new MainSys();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            mainSys.Req_GetKey();
        }

        private void ViewDataBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ChooseFilePathBtn_Click(object sender, EventArgs e)
        {
            DataTableGrid.DataSource = null;
            // Number_index = 0;
            FilePathInput.Text = String.Empty;
            SheetTableDrop.Items.Clear();
            OpenFileName openFileName = new OpenFileName();
            openFileName.structSize = Marshal.SizeOf(openFileName);
            openFileName.filter = "Excel文件(*xlsx/*xls)\0*.xlsx;*.xls\0";
            openFileName.file = new string(new char[1024]);
            openFileName.maxFile = openFileName.file.Length;
            openFileName.fileTitle = new string(new char[1024]);
            openFileName.maxFileTitle = openFileName.fileTitle.Length;
            openFileName.initialDir = Application.StartupPath.Replace('/', '\\');//默认路径
            openFileName.title = "选择*xlsx/*xls文件";
            openFileName.flags = 0x00080000 | 0x00001000 | 0x00000800 | 0x00000008;
            if (LocalDialog.GetOpenFileName(openFileName))    // 打开本地文件
            {
                FilePathInput.Text = openFileName.file;
                if (!string.IsNullOrEmpty(FilePathInput.Text))
                {
                    var s = FilePathInput.Text;
                    List<string> sheetTable = new List<string>();
                     LoadingHelper.ShowLoading("正在从excel 中获取数据，请稍后！！", this, (obj) =>
                     {
                         Xlsx xlsx = new Xlsx();
                         sheetTable = xlsx.GetSheet(s);// 会得到一张表
                     });
                     if (sheetTable.Count > 0)
                     {
                         SetSheetData(sheetTable);
                     }
                     else
                     {
                         MessageBox.Show("请选择文件！！");
                     }
                }
            }
        }

        private void SetSheetData(List<string> sheetTable)
        {
             if(sheetTable.Count > 0)
             {
                for(int i =0;i< sheetTable.Count; i++)
                {
                    SheetTableDrop.Items.Add(sheetTable[i]);    
                }
             }
            else
            {
                MessageBox.Show("请重新选择文件！！");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sl"></param>
        public  void SetPersonTitleTxt(string sl)
        {
            personDataLabel.Text = sl;
        }
    }
}
