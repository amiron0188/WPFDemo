using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo7
{
    public class MainViewModel : ViewModelBase
    {
        private string name;
        public string Name { 
            get => name;
            set { 
                name = value;
                OnPropertyChanged();
            } }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }
        public MyCommand ShowCommand { get; set; }

        public MainViewModel()
        {
            ShowCommand = new MyCommand(Show);
            Name = "Hello";
        }

        public void Show()
        {
            Name = "点击了按钮!";
            Title = "我是标题";
            MessageBox.Show(Name);
        }

    }
}
