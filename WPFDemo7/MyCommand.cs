using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFDemo7
{
    public class MyCommand:ICommand
    {
        Action executeAction;

        public event EventHandler CanExecuteChanged;

        public MyCommand(Action action)
        {
            executeAction = action;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            executeAction();
        }
    }
}
