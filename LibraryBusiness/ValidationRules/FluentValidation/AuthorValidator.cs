using FluentValidation;
using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness.ValidationRules.FluentValidation
{
    public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            
            RuleFor(p => p.AuthorName).NotEmpty();
            RuleFor(p => p.AuthorSurname).NotEmpty();
            
        }
    }
}
