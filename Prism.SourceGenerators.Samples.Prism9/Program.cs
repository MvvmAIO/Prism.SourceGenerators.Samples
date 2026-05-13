using System.Linq;
using Avalonia;
using Avalonia.Data.Core.Plugins;

namespace Prism.SourceGenerators.Samples.Prism9;

internal static class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }

    private static AppBuilder BuildAvaloniaApp()
    {
        EnsureIndeiValidationPlugin();

        return AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
    }

    /// <summary>
    /// Registers INotifyDataErrorInfo support before any bindings are created (TextBox border + inline validation template).
    /// </summary>
    private static void EnsureIndeiValidationPlugin()
    {
        if (!BindingPlugins.DataValidators.Any(static v => v is IndeiValidationPlugin))
            BindingPlugins.DataValidators.Add(new IndeiValidationPlugin());
    }
}
