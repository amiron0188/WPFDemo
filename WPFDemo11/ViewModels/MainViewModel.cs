using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDemo11.Views;

namespace WPFDemo11.ViewModels
{
    public class MainViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; private set; }

        public ReactiveCommand<IRoutableViewModel, IRoutableViewModel> OpenCommand { get; protected set; }

        public ReactiveCommand<Unit, IRoutableViewModel> Back { get; }

        public MainViewModel(RoutingState? routingState = null)
        {
            Router = routingState ?? new RoutingState();
            Back = Router.NavigateBack;
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

            OpenCommand = ReactiveCommand.CreateFromObservable<IRoutableViewModel, IRoutableViewModel>(viewModel => Router.Navigate.Execute(viewModel));
        }

    }
}
