// MainViewModel.cs
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class MainViewModel : INotifyPropertyChanged
{
    private int _rowCount;

    public int RowCount
    {
        get => _rowCount;
        set
        {
            _rowCount = value;
            OnPropertyChanged();
        }
    }

    // Implement INotifyPropertyChanged interface
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    // Add methods to load CSV, count rows, etc.
}
