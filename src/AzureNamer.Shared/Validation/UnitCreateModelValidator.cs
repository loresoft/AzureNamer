using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<UnitCreateModel>>]
public partial class UnitCreateModelValidator
    : AbstractValidator<UnitCreateModel>
{
    public UnitCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(100);
        RuleFor(p => p.Abbreviation).NotEmpty();
        RuleFor(p => p.Abbreviation).MaximumLength(10);
        RuleFor(p => p.Description).MaximumLength(255);
        #endregion
    }

}
