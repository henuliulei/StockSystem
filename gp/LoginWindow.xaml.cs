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
using System.Data;

namespace gp
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
         
        public LoginWindow()
        {
            InitializeComponent();
          
        }
        public void toMain(object sender, RoutedEventArgs e)

        {
            String str1 = userTb.Text;
            String str2 = passwordTb.Password;
            if(str1.Trim().ToString()=="" || str2.Trim().ToString() == "")
            {
                Messagebox.MyMessageBox.Show("请输入用户名和密码");

            }
            else
            {
                String sql1 = "select passwd,login_name from users where login_name='" + str1 + "' and passwd= '" + str2 + "'";
                Bussiness s = new Bussiness();
                DataTable dataTable = new DataTable();
                dataTable = s.ExecuteQuery(sql1);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {

                    selected.Person.name = str1;
                    selected.Person.passwd = str2;

                    MainWindow mainWindow = new MainWindow();

                    selected.GetMainWindow.main = mainWindow;

                    this.Close();
                    mainWindow.ShowDialog();
                }
                else
                {
                    
                    Messagebox.MyMessageBox.Show("用户名或密码输入错误，请重新输入");

                }
            }
            
        }

        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            register register = new register();
            this.Close();
            register.ShowDialog();
        }

       
    }
}
