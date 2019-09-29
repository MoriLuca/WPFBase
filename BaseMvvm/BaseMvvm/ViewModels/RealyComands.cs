using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BaseMvvm.ViewModels
{
    public class RealyComands : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> _executeMethod;
        private Predicate<object> _canExecuteMethod;

        public RealyComands(Action<object> execute, Predicate<object> canExecute)
        {
            _executeMethod = execute;
            _canExecuteMethod = canExecute;
        }

        public RealyComands(Action<object> execute) : this(execute, null) { }

        public bool CanExecute(object parameter) => (_canExecuteMethod == null) ? true : _canExecuteMethod.Invoke(parameter);

        public void Execute(object parameter) => _executeMethod.Invoke(parameter);

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        
        
    }
}
