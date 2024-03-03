using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<UserOrganizationUpdateModel>>]
public partial class UserOrganizationUpdateModelValidator
    : AbstractValidator<UserOrganizationUpdateModel>
{
    public UserOrganizationUpdateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
