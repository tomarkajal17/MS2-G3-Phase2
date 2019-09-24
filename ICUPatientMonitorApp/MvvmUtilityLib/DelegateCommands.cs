using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmUtilityLib
{
    public class DelegateCommands : ICommand
    {
        //Command Parameters
        public event EventHandler CanExecuteChanged;
        private Action<object> _executeMethodAddress;
        private Func<object, bool> _canExcuteMethodAddress;

        public DelegateCommands(Action<object> actionMethodAddress, Func<object, bool> canExccuteMethodAddress)
        {
            _executeMethodAddress = actionMethodAddress;
            _canExcuteMethodAddress = canExccuteMethodAddress;
        }

        public bool CanExecute(object parameter)
        {
            return this._canExcuteMethodAddress.Invoke(parameter);
        }
        public void Execute(object parameter)
        {
            this._executeMethodAddress.Invoke(parameter);
        }

    }
}
