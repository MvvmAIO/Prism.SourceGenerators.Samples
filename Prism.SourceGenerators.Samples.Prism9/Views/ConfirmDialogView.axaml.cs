using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Prism.SourceGenerators;
using Prism.SourceGenerators.Samples.Prism9.ViewModels;

namespace Prism.SourceGenerators.Samples.Prism9.Views;

[RegisterDialog<ConfirmDialogViewModel>(Name = "ConfirmDelete")]
public partial class ConfirmDialogView : UserControl
{
    public ConfirmDialogView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
