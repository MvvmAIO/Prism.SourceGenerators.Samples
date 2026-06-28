using Avalonia.Controls;
using Prism.SourceGenerators;
using Prism.SourceGenerators.Samples.Prism9.ViewModels;

namespace Prism.SourceGenerators.Samples.Prism9.Views;

[RegisterForNavigation<ValidationAttributeDemoViewModel>(Name = "ValidationAttr")]
public partial class ValidationAttributeDemoView : UserControl
{
    public ValidationAttributeDemoView()
    {
        InitializeComponent();
    }
}
