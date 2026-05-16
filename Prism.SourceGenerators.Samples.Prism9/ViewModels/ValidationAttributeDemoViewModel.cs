using System.ComponentModel.DataAnnotations;
using Prism.SourceGenerators;

namespace Prism.SourceGenerators.Samples.Prism9.ViewModels;

/// <summary>
/// Demonstrates the <b>attribute-only</b> approach: annotate with <see cref="BindableValidatorAttribute"/>
/// instead of inheriting from <see cref="BindableValidator"/> directly.
/// The generator synthesizes the same base class inline.
/// </summary>
[BindableValidator]
public partial class ValidationAttributeDemoViewModel
{
    public ValidationAttributeDemoViewModel()
    {
        ValidateAllProperties();
    }

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Name is required.")]
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters.")]
    [MaxLength(20, ErrorMessage = "Name must be at most 20 characters.")]
    public partial string Name { get; set; } = "";

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Age is required.")]
    [Range(1, 120, ErrorMessage = "Age must be between 1 and 120.")]
    public partial string Age { get; set; } = "";

    public string HasErrorsSummary => HasErrors ? "Validation: errors present." : "Validation: no errors.";

    [DelegateCommand]
    private void ValidateAll() => ValidateAllProperties();

    [DelegateCommand]
    private void ClearAll() => ClearAllErrors();
}
