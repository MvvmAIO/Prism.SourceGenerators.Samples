using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.SourceGenerators.Samples.Wpf.ViewModels;
using Prism.SourceGenerators.Samples.Wpf.Views;

namespace Prism.SourceGenerators.Samples.Wpf;

public partial class App : PrismApplication
{
    protected override Window CreateShell()
    {
        var window = Container.Resolve<MainWindow>();
        window.DataContext = Container.Resolve<MainViewModel>();
        return window;
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<MainViewModel>();
        containerRegistry.RegisterSingleton<MainWindow>();
    }
}
