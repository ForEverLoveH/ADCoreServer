using ADCommandServer.ClientWindow;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCommandServer 
{
     public class LoadingHelper
    {
        /// <summary>
        /// 开始加载
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ownerForm"></param>
        /// <param name="work"></param>
        /// <param name="workArg"></param>
        public static void ShowLoading(string message, Form ownerForm, ParameterizedThreadStart work, object workArg = null)
        {
            var loadingForm = new FrmLoading(message);
            dynamic expandoObject = new ExpandoObject();
            expandoObject.Form = loadingForm;
            expandoObject.WorkArg = workArg;
            loadingForm.SetWorkAction(work, expandoObject);
            loadingForm.ShowDialog(ownerForm);
            if (loadingForm.WorkException != null)
            {
                throw loadingForm.WorkException;
            }
        }
    }
}
