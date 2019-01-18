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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gp.selected
{
    /// <summary>
    /// help1.xaml 的交互逻辑
    /// </summary>
    public partial class help1 : Page
    {
        public help1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
           
            string str = "可以从基本面和技术面来分析：\n"+
"基本面可以先看股票所处的行业，再细分其子行业，即这只股票主要做什么，分析目前国家\n" +
"对此行业是否有政策支持，若有，再看股票的业绩，最简单的方法是看每股收益和市盈率。\n" +
"技术面如果不太懂技术分析，最简单的办法是看成交量，看近期该股的走势是否放量突破\n " +
"短期均线或压力位，这是股票初学者了解股票最简单的办法 \n";
            text.Text = str;

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string str = "第一步：了解证券市场最基础的知识和规则" +"\n"+
            "第二步：学习投资分析传统的经典理论和方法" + "\n"+
            "第三步：在前两步基础上，对股市投资产生自己的认识，对股价变动的原因形成自己的理解和理论" + "\n"+
            "第四步：在自己对证券市场认识和理解的指导下，形成自己的方法体系和工具体系以及交易规则" + "\n"+
           " 第五步：在该系统模拟炒股，深临其境体味股市风险" + "\n"+
            "第六步：投入2000 - 6000，开户实战，不断总结经验";
            text.Text = str;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string str = "根据2018年12月20日发布的最新消息，一个投资者在同一个市场可以申请开立多个A股账户";
            text.Text = str;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string str = "感谢使用我们的系统，如有任何建议，欢迎通过下面的邮箱向我们提出意见，我们将在一个工作日内回复" + "\n" +
                "1957598452@qq.com";
            text.Text = str;

        }
    }
}
