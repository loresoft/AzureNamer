using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<SegmentUpdateModel>>]
public partial class SegmentUpdateModelValidator
    : AbstractValidator<SegmentUpdateModel>
{
    public SegmentUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(100);
        #endregion
    }

}
