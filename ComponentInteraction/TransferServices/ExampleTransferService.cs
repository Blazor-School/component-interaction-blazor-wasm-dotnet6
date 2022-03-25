using ComponentInteraction.Models;
using System.Collections.ObjectModel;

namespace ComponentInteraction.TransferServices;

public class ExampleTransferService
{
    private string _data = "Blazor School";
    public string Data
    {
        get => _data;
        set
        {
            _data = value;
            DataChanged?.Invoke(this, value);
        }
    }
    public event EventHandler<string> DataChanged = (sender, value) => { };

    public ObservableCollection<ExampleClass> ExampleInstances { get; set; } = new();
}
