using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;
namespace gp
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
       
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String str1 = text1.Text;
            String str2 = text2.Text;
            if (str1 == str2)
            {
                Messagebox.MyMessageBox.Show("两次密码输入的密码一样，请重新输入");
               
                text1.Text = "";
                text2.Text = "";
            }
            else if(str2 == "" || str1 == "")
            {
                Messagebox.MyMessageBox.Show("请输入正确的密码格式");

            }
            else {
              
               
               // MessageBox.Show(selected.Person.passwd);
                String sql = "select passwd from users where login_name='" + selected.Person.name + "'and passwd='"+str1+"'";
                Bussiness bussiness = new Bussiness();
                DataTable dt = new DataTable();
                dt = bussiness.ExecuteQuery(sql);
                if (dt != null && dt.Rows.Count == 0)
                {
                    Messagebox.MyMessageBox.Show("原密码输入错误，请重新输入");
                  
                    text1.Text = "";
                    text2.Text = "";

                }
                else
                {
                    String sql1 = "update  users set passwd='"+str2+"' where login_name='" + selected.Person.name + "'and passwd='" + str1 + "'";
                    Bussiness bussiness1 = new Bussiness();
                    DataTable dt1 = new DataTable();
                    dt1 = bussiness1.ExecuteQuery(sql1);
                    Messagebox.MyMessageBox.Show("更改成功");
                   
                    
                }
              
                
    
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            selected.GetMainWindow.f().Close();
            loginWindow.ShowDialog();
        }

      
    
    }
}
