using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<UserOrganizationCreateModel>>]
public partial class UserOrganizationCreateModelValidator
    : AbstractValidator<UserOrganizationCreateModel>
{
    public UserOrganizationCreateModelValidator()
    {
        #region Generated Constructor
        #endregion
    }

}
