using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Prism.SourceGenerators;
using Prism.SourceGenerators.Samples.Prism9.ViewModels;

namespace Prism.SourceGenerators.Samples.Prism9.Views;

[RegisterForNavigation<ValidationDemoViewModel>(Name = "Validation")]
public partial class ValidationDemoView : UserControl
{
    public ValidationDemoView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
