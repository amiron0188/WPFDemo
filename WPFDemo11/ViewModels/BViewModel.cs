using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo11.ViewModels
{
    public class BViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => nameof(BViewModel);

        public IScreen HostScreen { get; protected set; }
    }
}
