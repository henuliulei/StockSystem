using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gp
{
    /// <summary>
    /// register.xaml 的交互逻辑
    /// </summary>
    public partial class register : Window
    {
        public register()
        {
            InitializeComponent();
        }

        private void toLogin(object sender, RoutedEventArgs e)
        {
            int flag1 = 0;
            int flag2 = 0;
            int flag3 = 0;
            int flag4 = 0;

            // MessageBox.Show(nameTb.Text.Trim().Length.ToString());
            if (nameTb.Text.Trim().Length>5 || nameTb.Text.Trim().Length <2)
            {
                label1.Foreground = Brushes.Red;
                nameTb.Text = "";
                flag1 = 1;
            }
            else
            {
                label1.Foreground = Brushes.Gray;
                flag1 = 0;
            }
            if (ageTb.Text.Trim().Length > 5 || ageTb.Text.Trim().Length < 2)
            {
                label2.Foreground = Brushes.Red;
                ageTb.Text = "";
                flag2 = 1;
            }
            else
            {
                label2.Foreground = Brushes.Gray;
                flag2 = 0;
            }
            if (passWordTb.Password.Trim().Length > 9 || passWordTb.Password.Trim().Length < 3)
            {
                label3.Foreground = Brushes.Red;
                passWordTb.Password = "";
                flag3 = 1;
            }
            else
            {
                label3.Foreground = Brushes.Gray;
                flag3 = 0;
            }
            if (passWordTb.Password.Trim().ToString().Equals(qrPasswprdTb.Password.Trim().ToString())==false)
            {
                label4.Foreground = Brushes.Red;
                qrPasswprdTb.Password = "";
                flag4 = 1;
            }
            else
            {
                label4.Foreground = Brushes.Gray;
                flag4 = 0;
            }
            if(flag1==0 && flag2==0 && flag3==0 && flag4==0)
            {

                LoginWindow loginWindow = new LoginWindow();
                this.Close();
                string truename = this.nameTb.Text.ToString();
                string loginname = this.ageTb.Text.ToString();
                string password = this.passWordTb.Password.ToString();
                string password1 = this.qrPasswprdTb.Password.ToString();
                Bussiness business = new Bussiness();
                string sqlinsert = "insert into users values('" + truename + "','" + loginname + "','" + password + "',1,10000,0)";
                if (password.Equals(password1))
                {
                    int m = business.ExecuteUpdate(sqlinsert);
                    if (m > 0)
                    {
                        //Messagebox.MyMessageBox.Show("注册成功！欢迎您" + truename);
                        
                        loginWindow.ShowDialog();
                    }
                    else
                    {
                        Messagebox.MyMessageBox.Show("注册失败,请重新注册！");
                       
                        this.ClearValue();
                        this.Show();
                    }
                }
                else
                {
                    Messagebox.MyMessageBox.Show("两次密码输入不一致!");
         
                    this.ClearValue();
                    this.Show();
                }
            }

        }

        private void ClearValue()
        {
            this.nameTb.Clear();
            this.ageTb.Clear();
            this.passWordTb.Clear();
            this.qrPasswprdTb.Clear();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            this.Close();
            loginWindow.ShowDialog();
        }
    }
}
