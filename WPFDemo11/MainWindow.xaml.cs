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
using WPFDemo11.ViewModels;

namespace WPFDemo11
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
                block(this.Bind(ViewModel, vm => vm.Router, view => view.routedViewHost.Router));
                block(this.BindCommand(ViewModel, vm => vm.OpenCommand, view => view.OpenA, Observable.Return(new AViewModel())));
                block(this.BindCommand(ViewModel, vm => vm.OpenCommand, view => view.OpenB, Observable.Return(new BViewModel())));
                block(this.BindCommand(ViewModel, vm => vm.OpenCommand, view => view.OpenC, Observable.Return(new CViewModel())));
                block(this.BindCommand(ViewModel, vm => vm.Back, view => view.Back));
            });
        }
    }
}
