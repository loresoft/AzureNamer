using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<HistoryUpdateModel>>]
public partial class HistoryUpdateModelValidator
    : AbstractValidator<HistoryUpdateModel>
{
    public HistoryUpdateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(100);
        #endregion
    }

}
