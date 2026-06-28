using Prism.Dialogs;
using Prism.Mvvm;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Prism9.ViewModels;

[DialogAware(Title = "Confirm delete")]
public partial class ConfirmDialogViewModel : BindableBase
{
    [ObservableProperty]
    public partial string Message { get; set; } = "Delete this item?";

    [DelegateCommand]
    private void Ok()
    {
        RequestClose.Invoke(ButtonResult.OK);
    }

    [DelegateCommand]
    private void Cancel()
    {
        RequestClose.Invoke(ButtonResult.Cancel);
    }

    partial void OnDialogOpenedCore(IDialogParameters parameters)
    {
        if (parameters is DialogParameters dialogParameters
            && dialogParameters.TryGetValue<string>("message", out var message)
            && !string.IsNullOrWhiteSpace(message))
        {
            Message = message;
        }
    }
}