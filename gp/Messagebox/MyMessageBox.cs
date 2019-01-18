using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gp.Messagebox
{
    class MyMessageBox
    {
        public static int OK = 0;
        public static int OKCANCLE = 1;
        public MyMessageBox() { }

        public static void Show(string mess)
        {
            MessageBoxOK myMessageBoxOK = new MessageBoxOK(mess);
            myMessageBoxOK.Show();

        }
        /// <summary>
        /// 显示对话框
        /// </summary>
        /// <param name="mess">提示消息</param>
        /// <param name="style">对话框样式</param>
        public static bool? ShowDialog(string mess, int style)
        {
            switch (style)
            {
                case 0:
                    MessageBoxOK myMessageBoxOK = new MessageBoxOK(mess);
                    return myMessageBoxOK.ShowDialog();
                    break;
                case 1:
                    MessageBoxOKCancle myMessageBoxOKCancle = new MessageBoxOKCancle(mess);
                    return myMessageBoxOKCancle.ShowDialog();
                    break;
                default:
                    return false;
            }
        }

    }
  }
