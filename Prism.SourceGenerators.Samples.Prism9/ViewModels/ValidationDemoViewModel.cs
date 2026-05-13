using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Prism9.ViewModels;

/// <summary>
/// Demonstrates <see cref="BindableValidator"/> with <see cref="NotifyDataErrorInfoAttribute"/> on
/// <see cref="ObservablePropertyAttribute"/> <b>partial properties</b>. DataAnnotations stay on the partial
/// declaration; the generator does not duplicate them on the implementing partial, while still emitting
/// <c>ValidateProperty</c> in the setter.
/// </summary>
public partial class ValidationDemoViewModel : BindableValidator
{
    public ValidationDemoViewModel()
    {
        ErrorsChanged += OnErrorsChanged;
        ValidateAllProperties();
    }

    private void OnErrorsChanged(object? sender, DataErrorsChangedEventArgs e)
    {
        string? name = e.PropertyName;
        if (string.IsNullOrEmpty(name) || name == nameof(Username))
            RaisePropertyChanged(nameof(UsernameErrors));
        if (string.IsNullOrEmpty(name) || name == nameof(Email))
            RaisePropertyChanged(nameof(EmailErrors));
        RaisePropertyChanged(nameof(HasErrorsSummary));
    }

    partial void OnUsernameChanged(string value) => RaisePropertyChanged(nameof(UsernameErrors));

    partial void OnEmailChanged(string value) => RaisePropertyChanged(nameof(EmailErrors));

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Username is required.")]
    [MinLength(2, ErrorMessage = "Username must be at least 2 characters.")]
    public partial string Username { get; set; } = "";

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public partial string Email { get; set; } = "";

    public string UsernameErrors => FormatErrors(GetErrors(nameof(Username)));

    public string EmailErrors => FormatErrors(GetErrors(nameof(Email)));

    public string HasErrorsSummary => HasErrors ? "Validation: errors present." : "Validation: no errors.";

    [DelegateCommand]
    private void ValidateAll()
    {
        ValidateAllProperties();
    }

    [DelegateCommand]
    private void ClearAll()
    {
        ClearAllErrors();
    }

    private static string FormatErrors(IEnumerable errors)
    {
        return string.Join(
            "; ",
            errors.Cast<ValidationResult>().Select(r => r.ErrorMessage).OfType<string>());
    }
}
