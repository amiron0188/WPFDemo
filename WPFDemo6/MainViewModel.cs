using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo6
{
    public class MainViewModel
    {
        public string Name { get; set; }
        public MyCommand ShowCommand { get; set; }

        public MainViewModel()
        {
            ShowCommand = new MyCommand(Show);
            Name = "Hello";
        }

        public void Show()
        {
            Name = "点击了按钮!";
            MessageBox.Show(Name);
        }
    }
}
