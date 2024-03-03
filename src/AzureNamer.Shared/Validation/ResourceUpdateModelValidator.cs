using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<ResourceUpdateModel>>]
public partial class ResourceUpdateModelValidator
    : AbstractValidator<ResourceUpdateModel>
{
    public ResourceUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).MaximumLength(100);
        RuleFor(p => p.Namespace).NotEmpty();
        RuleFor(p => p.Namespace).MaximumLength(255);
        RuleFor(p => p.Abbreviation).NotEmpty();
        RuleFor(p => p.Abbreviation).MaximumLength(10);
        RuleFor(p => p.ValidationDescription).MaximumLength(4000);
        RuleFor(p => p.ValidationExpression).MaximumLength(2000);
        #endregion
    }

}
