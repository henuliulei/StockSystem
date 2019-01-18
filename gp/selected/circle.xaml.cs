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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace gp.selected
{
    /// <summary>
    /// circle.xaml 的交互逻辑
    /// </summary>

    public partial class circle : Page
    {
        DispatcherTimer _timer = new DispatcherTimer();  //UI定时器
        Storyboard storyboard_imgs = null;
        DoubleAnimationUsingKeyFrames daukf_img1 = null;

        public circle()
        {
            InitializeComponent();
            _timer.Interval = new TimeSpan(0, 0, 0, 8);
            _timer.Tick += TimerElapsed;
            storyboard_imgs = new Storyboard();
            daukf_img1 = new DoubleAnimationUsingKeyFrames();
            Storyboard.SetTarget(daukf_img1, sp1);
            Storyboard.SetTargetProperty(daukf_img1, new PropertyPath("(Canvas.Left)"));
            _timer.Start();
        }
        int index = 0;
        void TimerElapsed(object o, EventArgs e)
        {
            double start_left = 0;
            double end_left = 0;
            index++;
            if (index % 5 == 1)
            {
                end_left = -lab1.ActualWidth;
            }
            else if (index % 5 == 2)
            {
                start_left = -lab1.ActualWidth;
                end_left = -lab1.ActualWidth - lab2.ActualWidth;
            }
            else if (index % 5 == 3)
            {
                start_left = -lab1.ActualWidth - lab2.ActualWidth;
                end_left = -lab1.ActualWidth - lab2.ActualWidth - lab3.ActualWidth;
            }
            else if (index % 5 == 4)
            {
                start_left = -lab1.ActualWidth - lab2.ActualWidth;
                end_left = -lab1.ActualWidth - lab2.ActualWidth - lab3.ActualWidth-lab4.ActualWidth;
            }
            else if (index % 5 == 0)
            {
                start_left = -lab1.ActualWidth - lab2.ActualWidth;
                end_left = -lab1.ActualWidth - lab2.ActualWidth - lab3.ActualWidth-lab5.ActualWidth;
            }
            daukf_img1.KeyFrames.Clear();
            storyboard_imgs.Children.Clear();
            LinearDoubleKeyFrame k1_img1 = new LinearDoubleKeyFrame(start_left, KeyTime.FromTimeSpan(new TimeSpan(0, 0, 0)));
            LinearDoubleKeyFrame k2_img1 = new LinearDoubleKeyFrame(end_left, KeyTime.FromTimeSpan(new TimeSpan(0, 0, 8)));
            daukf_img1.KeyFrames.Add(k1_img1);
            daukf_img1.KeyFrames.Add(k2_img1);
            storyboard_imgs.Children.Add(daukf_img1);
            storyboard_imgs.Begin();
        }
    }
}
