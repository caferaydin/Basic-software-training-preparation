using FluentValidation;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Rules.Validation.Fluent
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty();
            RuleFor(c => c.CategoryName).MinimumLength(2);
        }
    }
}
