using Prism.Mvvm;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Wpf.ViewModels;

/// <summary>
/// Minimal WPF shell ViewModel demonstrating <see cref="ObservablePropertyAttribute"/> and <see cref="DelegateCommandAttribute"/>.
/// </summary>
public partial class MainViewModel : BindableBase
{
    [ObservableProperty]
    private string _title = "Prism WPF + Source Generators";

    [ObservableProperty]
    private string _headline = "WPF sample";

    [ObservableProperty]
    private string _body =
        "MvvmAIO.Prism.SourceGenerators on Prism 9 WPF — field-backed ObservableProperty and DelegateCommand.";

    [ObservableProperty]
    private int _counter;

    [ObservableProperty]
    private string _statusMessage = "Ready";

    [DelegateCommand]
    private void Increment()
    {
        Counter++;
        StatusMessage = $"Incremented at {DateTime.Now:HH:mm:ss}";
    }
}
