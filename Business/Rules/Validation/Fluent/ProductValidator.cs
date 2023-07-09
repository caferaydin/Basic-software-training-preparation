using FluentValidation;
using SmartPro.Entities.Concrete;

namespace SmartPro.Business.Rules.Validation.Fluent
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductDescription).NotEmpty();
            RuleFor(p => p.ProductDescription).MinimumLength(10);
            RuleFor(p => p.Stock).NotEmpty();
            RuleFor(p => p.Stock).GreaterThan(0);
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);
        }
    }
}
