using Prism.Mvvm;
using Prism.Navigation.Regions;
using Prism.SourceGenerators;
using Prism.SourceGenerators.Samples.Prism9.Services;

namespace Prism.SourceGenerators.Samples.Prism9.ViewModels;

[NavigationAware]
public partial class DashboardViewModel : BindableBase
{
    [ObservableProperty]
    public partial string Headline { get; set; } = "Dashboard";

    [ObservableProperty]
    public partial string Body { get; set; } =
        "This view is shown via Prism region navigation (IRegionManager.RequestNavigate).";

    [ObservableProperty]
    public partial string NavigationNote { get; set; } = "";

    public DashboardViewModel(ISettingsService settings, IDateTimeProvider clock)
    {
        Body =
            $"{settings.AppSectionTitle} Resolved services: {clock.Now:yyyy-MM-dd HH:mm} (from IDateTimeProvider).";
    }

    partial void OnNavigatedToCore(NavigationContext navigationContext)
    {
        NavigationNote = $"OnNavigatedToCore @ {navigationContext.Uri}";
    }
}
