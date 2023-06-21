using FluentValidation;
using SmartPro.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro.Business.Rules.Validation.Fluent
{
    public class SubCategoryValidator : AbstractValidator<SubCategory>
    {
        public SubCategoryValidator()
        {
            RuleFor(s=> s.SubCategoryName).NotEmpty();
            RuleFor(s=> s.SubCategoryName).MinimumLength(2);
            RuleFor(s=> s.CategoryId).NotEmpty();
        }
    }
}
