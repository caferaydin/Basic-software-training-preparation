using FluentValidation;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Rules.Validation.Fluent
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
