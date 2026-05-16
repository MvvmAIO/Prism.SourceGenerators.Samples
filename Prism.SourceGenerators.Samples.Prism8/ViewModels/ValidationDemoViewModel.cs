using System.ComponentModel.DataAnnotations;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Prism8.ViewModels;

/// <summary>
/// Demonstrates <see cref="BindableValidator"/> with <see cref="NotifyDataErrorInfoAttribute"/> on
/// <see cref="ObservablePropertyAttribute"/> <b>field targets</b> (C# 12, Prism 8).
/// DataAnnotations on fields are forwarded to the generated property so the validator can see them.
/// </summary>
public partial class ValidationDemoViewModel : BindableValidator
{
    public ValidationDemoViewModel()
    {
        ValidateAllProperties();
    }

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Username is required.")]
    [MinLength(2, ErrorMessage = "Username must be at least 2 characters.")]
    [MaxLength(16, ErrorMessage = "Username must be at most 16 characters.")]
    private string _username = "";

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    private string _email = "";

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

}
