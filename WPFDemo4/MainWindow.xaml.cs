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

namespace WPFDemo4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Color> test = new List<Color>()
            { 
                new Color() { Code = "#FFB6C1", Name = "浅粉红"},
                 new Color() { Code = "#FFC0CB", Name = "粉红"},
                  new Color() { Code = "#DC143C", Name = "深红红"},
                   new Color() { Code = "#FFF0F5", Name = "淡紫红"},
            };

            Grid.ItemsSource = test;
        }

        public class Color
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }
    }
}
