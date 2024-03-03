using System;
using FluentValidation;
using AzureNamer.Shared.Models;

namespace AzureNamer.Shared.Validation;

[RegisterSingleton<IValidator<HistoryCreateModel>>]
public partial class HistoryCreateModelValidator
    : AbstractValidator<HistoryCreateModel>
{
    public HistoryCreateModelValidator()
    {
        #region Generated Constructor
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(100);
        #endregion
    }

}
