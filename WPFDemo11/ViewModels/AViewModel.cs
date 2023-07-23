using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo11.ViewModels
{
    public class AViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => nameof(AViewModel);

        public IScreen HostScreen { get; protected set; }

    }
}
