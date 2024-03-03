using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<SegmentCreateModel>>]
public partial class SegmentCreateModelValidator
    : AbstractValidator<SegmentCreateModel>
{
    public SegmentCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(100);
        #endregion
    }

}
