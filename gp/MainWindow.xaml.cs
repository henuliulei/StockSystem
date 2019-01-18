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
using System.Windows.Threading;

namespace gp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Dictionary<string, Uri> allViews = new Dictionary<string, Uri>();                                                                            //  System.Timers.Timer timer = new System.Timers.Timer();
   
        public MainWindow()
        {
            InitializeComponent();
           
           
            selected.Welcome1 welcome1 = new selected.Welcome1();
            mainFrame.Content = welcome1;
            selected.circle circle = new selected.circle();
            mainFrame1.Content = circle;
                //添加页面的Uri地址，采用相对路径，根路径是项目名,实现allViews的初始化
            allViews.Add("page1", new Uri("selected/Welcome1.xaml", UriKind.Relative));
            allViews.Add("page4", new Uri("selected/SheZhi.xaml", UriKind.Relative));
            allViews.Add("page2", new Uri("selected/stock.xaml", UriKind.Relative));
            allViews.Add("page3", new Uri("selected/Zhanghu1.xaml", UriKind.Relative));
            allViews.Add("page5", new Uri("selected/help1.xaml", UriKind.Relative));
        }
       
        /*
        *页面一按钮的响应事件函数，实现导航到page1
        */
        public void page1Button(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(allViews["page1"]);                    //Frame类的导航函数，参数时页面的Uri
        }

        /*
        *页面二按钮的响应事件函数，实现导航到page2
        */
      
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(allViews["page2"]);
        }
       

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            
           
           //selected.Zhanghu1 zhanghu = new selected.Zhanghu1();
            
            mainFrame.Navigate(allViews["page3"]);
            
            
        }
        public void page2Button(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(allViews["page4"]);                    //Frame导航函数，导航到page2
        }
        public void page3Button(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(allViews["page5"]);                    //Frame导航函数，导航到page2
        }


    }
}
