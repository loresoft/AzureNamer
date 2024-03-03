using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<UserUpdateModel>>]
public partial class UserUpdateModelValidator
    : AbstractValidator<UserUpdateModel>
{
    public UserUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(100);
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.Email).MaximumLength(4000);
        RuleFor(p => p.Provider).MaximumLength(4000);
        #endregion
    }

}
