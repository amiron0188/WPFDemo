using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo11.ViewModels
{
    public class CViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => nameof(CViewModel);

        public IScreen HostScreen { get; protected set; }
    }
}
