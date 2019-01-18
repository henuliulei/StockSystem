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
    /// MessageBoxOK.xaml 的交互逻辑
    /// </summary>
    public partial class MessageBoxOK : Window
    {
        private string mess;

        public MessageBoxOK()
        {
            InitializeComponent();
        }

        public MessageBoxOK(string mess)
        {
            InitializeComponent();
            message.Text = mess;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.DialogResult = false;
            }
            catch (Exception ex) { }

            this.Close();
        }
    }

}

