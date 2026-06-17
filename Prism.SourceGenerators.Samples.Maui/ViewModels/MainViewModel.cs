using Prism.Mvvm;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Maui.ViewModels;

/// <summary>
/// Minimal MAUI ViewModel with partial-property <see cref="ObservablePropertyAttribute"/> (C# 13+).
/// </summary>
public partial class MainViewModel : BindableBase
{
    [ObservableProperty]
    public partial string Headline { get; set; } = "MAUI sample";

    [ObservableProperty]
    public partial string Body { get; set; } =
        "MvvmAIO.Prism.SourceGenerators on Prism 9 .NET MAUI (Windows target).";

    [ObservableProperty]
    public partial int Counter { get; set; }

    [DelegateCommand]
    private void Increment()
    {
        Counter++;
        Body = $"Counter is {Counter} (updated {DateTime.Now:HH:mm:ss}).";
    }
}
