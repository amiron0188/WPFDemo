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

namespace WPFDemo10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            // 创建一个双精度动画
            DoubleAnimation animation = new DoubleAnimation();

            animation.By = -30;
            //animation.From = btn.Width; 动画初始值
            //animation.To = btn.Width - 30 ; 动画结束值
            animation.Duration = TimeSpan.FromSeconds(2); // 设置动画持续时间
            animation.AutoReverse = true; // 往返执行
            animation.RepeatBehavior = new RepeatBehavior(5); // RepeatBehavior.Forever; 执行周期

            animation.Completed += delegate { btn.Content = "执行完毕!"; };
            // 在当前按钮执行该动画
            btn.BeginAnimation(Button.WidthProperty, animation);
        }
    }
}
