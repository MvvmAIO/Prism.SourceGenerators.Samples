using Prism.Dialogs;
using Prism.Mvvm;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Prism9.ViewModels;

[DialogAware(Title = "Confirm delete")]
public partial class ConfirmDialogViewModel : BindableBase
{
    [ObservableProperty]
    public partial string Message { get; set; } = "Delete this item?";

    // Prism 9 syntax: RequestClose is a DialogCloseListener that uses Invoke(ButtonResult).
    // Prism 8 would use: RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
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