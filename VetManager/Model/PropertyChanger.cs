using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

public class PropertyChanger : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public PropertyChanger()
    { 
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        // Bezpieczne wywołanie PropertyChanged
        var handler = PropertyChanged;
        if (handler != null)
        {
            // Jeśli jesteśmy w WPF i potrzebujemy Dispatchera
            if (System.Windows.Application.Current != null && 
                !System.Windows.Application.Current.Dispatcher.CheckAccess())
            {
                System.Windows.Application.Current.Dispatcher.Invoke(() =>
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                });
            }
            else
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        CommandManager.InvalidateRequerySuggested();
    }

    internal bool SetField<T>(ref T field, T value, string propertyName)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;
            
        field = value;
        OnPropertyChanged(propertyName);
        Debug.WriteLine("Zmieniłem właściwość");
        return true;
    }
}