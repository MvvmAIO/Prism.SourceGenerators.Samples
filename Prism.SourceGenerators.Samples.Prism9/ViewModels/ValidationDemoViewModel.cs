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
        ValidateAllProperties();
    }

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Username is required.")]
    [MinLength(2, ErrorMessage = "Username must be at least 2 characters.")]
    [MaxLength(16, ErrorMessage = "Username must be at most 16 characters.")]
    public partial string Username { get; set; } = "";

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public partial string Email { get; set; } = "";

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
