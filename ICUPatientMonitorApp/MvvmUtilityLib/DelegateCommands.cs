using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
/// <summary>
/// This is utility library
/// </summary>
namespace MvvmUtilityLib
{
    /// <summary>
    /// It provides the delegate functionality.
    /// </summary>
    public class DelegateCommands: ICommand
    {
        #region private DataMember
        private readonly Action<object> _executeMethodAddress;
        private readonly Func<object, bool> _canExcuteMethodAddress;
        #endregion

        #region Contructor
        public DelegateCommands(Action<object> actionMethodAddress, Func<object, bool> canExccuteMethodAddress)
        {
            _executeMethodAddress = actionMethodAddress;
            _canExcuteMethodAddress = canExccuteMethodAddress;
        }
        #endregion

        public event EventHandler CanExecuteChanged;
        /// <summary>
        /// It is for checking the function execution ability. 
        /// </summary>
        /// <param name="parameter">parameters</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return this._canExcuteMethodAddress.Invoke(parameter);
        }
        /// <summary>
        /// Executing the method
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this._executeMethodAddress.Invoke(parameter);
        }

    }
}
