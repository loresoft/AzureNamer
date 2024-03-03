using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<UserCreateModel>>]
public partial class UserCreateModelValidator
    : AbstractValidator<UserCreateModel>
{
    public UserCreateModelValidator()
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
