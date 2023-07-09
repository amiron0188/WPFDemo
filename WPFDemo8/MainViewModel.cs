using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDemo8
{
    public class MainViewModel : ReactiveObject
    {
        [Reactive]
        public string Name { get;set;}

        [Reactive]
        public string Title { get;set;}
        public ReactiveCommand<string,Unit> ShowCommand;

        public MainViewModel()
        {
            ShowCommand = ReactiveCommand.Create<string>(Show);
            Name = "Hello";
        }

        public void Show(string content)
        {
            Name = "点击了按钮!";
            Title = "我是标题";
            MessageBus.Current.SendMessage<string>(content, "Token1");
        }

    }
}
