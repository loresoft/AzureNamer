using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<InviteUpdateModel>>]
public partial class InviteUpdateModelValidator
    : AbstractValidator<InviteUpdateModel>
{
    public InviteUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(100);
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.Email).MaximumLength(255);
        RuleFor(p => p.SecurityKey).NotEmpty();
        RuleFor(p => p.SecurityKey).MaximumLength(255);
        #endregion
    }

}
