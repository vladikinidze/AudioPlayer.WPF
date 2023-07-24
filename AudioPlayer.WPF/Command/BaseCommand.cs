using System;
using System.Windows.Input;

namespace AudioPlayer.WPF.Command;

public abstract class BaseCommand : ICommand
{
    public virtual bool CanExecute(object? parameter) => true;

    public abstract void Execute(object? parameter);

    public event EventHandler? CanExecuteChanged;

    protected virtual void OnCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}