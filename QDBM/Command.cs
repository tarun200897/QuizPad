using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QPAD
{
    class Command : ICommand
    {
        Action action;
        Action<object> parameterizedAction;

        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="canExecute">if set to <c>true</c> [can execute].</param>
        public Command(Action action, bool canExecute = true)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="parameterizedAction">The parameterized action.</param>
        /// <param name="canExecute">if set to <c>true</c> [can execute].</param>
        public Command(Action<object> parameterizedAction, bool canExecute = true)
        {
            this.parameterizedAction = parameterizedAction;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Occurs when can execute is changed.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Bool indicating whether the command can execute.
        /// </summary>
        private bool canExecute = false;
        /// <summary>
        /// Gets or sets a value indicating whether this instance can execute.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance can execute; otherwise, <c>false</c>.
        /// </value>
        public bool CanExecute
        {
            get { return canExecute; }
            set
            {
                if (canExecute != value)
                {
                    canExecute = value;
                    EventHandler canExecuteChanged = CanExecuteChanged;
                    if (canExecuteChanged != null)
                        canExecuteChanged(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.
        ///  If the command does not require data to be passed,
        ///  this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        bool ICommand.CanExecute(object parameter)
        {
            return canExecute;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.
        ///  If the command does not require data to be passed,
        ///  this object can be set to null.</param>
        void ICommand.Execute(object parameter)
        {
            if (action != null)
            {
                action();
            }
            if (parameterizedAction != null)
            {
                parameterizedAction(parameter);
            }
        }
    }
}
