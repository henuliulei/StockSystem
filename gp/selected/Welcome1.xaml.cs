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
using SpeechLib;
namespace gp.selected
{
    /// <summary>
    /// Welcome1.xaml 的交互逻辑
    /// </summary>
    public partial class Welcome1 : Page
    {
        public Welcome1()
        {
            InitializeComponent();
            SpeechVoiceSpeakFlags flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice voice = new SpVoice();
            string voice_txt = "欢迎进入股票交易系统";
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(voice_txt, flag);
           
        }
        
    }
}
