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

namespace gp.Messagebox
{
    /// <summary>
    /// MessageBoxOKCancle.xaml 的交互逻辑
    /// </summary>
    public partial class MessageBoxOKCancle : Window
    {
        private string mess;

        public MessageBoxOKCancle()
        {
            InitializeComponent();
        }

        public MessageBoxOKCancle(string mess)
        {
            InitializeComponent();
            message.Text = mess;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            //如果window不是以Showdialog方式打开设置DialogResult时会引发异常
            try
            {
                this.DialogResult = true;
            }
            catch (Exception ex) {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.Close();
        }
        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            //如果window不是以Showdialog方式打开设置DialogResult时会引发异常
            try
            {
                this.DialogResult = false;
            }
            catch (Exception ex) {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning); 
        }
            this.Close();
        }
    }
}
