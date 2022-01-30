using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeManager.ViewModel.Command
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        private Action save;
        private bool canSave;

        public event EventHandler CanExecuteChanged;


        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException();
            _canExecute = canExecute;
        }

        public DelegateCommand(Action save, bool canSave)
        {
            this.save = save;
            this.canSave = canSave;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null
                ? true
                : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
