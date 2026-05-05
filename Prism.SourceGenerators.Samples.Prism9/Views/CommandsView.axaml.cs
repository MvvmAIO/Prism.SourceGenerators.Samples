using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Prism.SourceGenerators.Samples.Prism9.ViewModels;

namespace Prism.SourceGenerators.Samples.Prism9.Views;

public partial class CommandsView : UserControl
{
    public CommandsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
