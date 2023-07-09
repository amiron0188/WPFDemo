using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
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

namespace WPFDemo8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();

            this.WhenActivated(block =>
            {
                block(this.BindCommand(ViewModel, vm => vm.ShowCommand, v => v.Show, vm => vm.Title));
                block(this.Bind(ViewModel, vm => vm.Name, v => v.Name.Text));
                block(this.Bind(ViewModel, vm => vm.Title, v => v.Title.Text));
            });

            MessageBus.Current.Listen<string>("Token1")
                                .Subscribe(x => ShowToken(x));
        }

        void ShowToken(string value)
        {
            MessageBox.Show(value);
        }

    }
}
