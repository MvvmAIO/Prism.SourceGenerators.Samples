using Prism.Mvvm;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Uno.ViewModels;

/// <summary>
/// Headless ViewModel library for Uno / WinUI compatibility verification (no UI host).
/// Wire the same patterns into <c>Prism.Uno.WinUI</c> or WinUI 3 apps.
/// </summary>
[NavigationAware]
public partial class ShellViewModel : BindableBase
{
    [ObservableProperty]
    public partial string Title { get; set; } = "Uno / WinUI compatibility";

    [ObservableProperty]
    public partial string Message { get; set; } =
        "Generators compile against Prism.Core; use Prism.Uno.WinUI for navigation shell.";

    [DelegateCommand]
    private void Refresh() =>
        Message = $"Refreshed at {DateTime.Now:HH:mm:ss}";
}
