using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuakeRemakeKeybinder.Commands
{
    public class DelegateCommand : ICommand
    {
        private readonly Action execute;
        private readonly Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action ex, Func<bool> canEx = null)
        {
            execute = ex ?? throw new ArgumentNullException(nameof(ex));
            canExecute = canEx;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter)
        {
            execute();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
