using FluentValidation;
using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness.ValidationRules.FluentValidation
{
   public class BookValidator:AbstractValidator<Book>
    {

        public BookValidator()
        {
            
            RuleFor(p => p.AuthorName).NotEmpty();
            RuleFor(p => p.BookName).NotEmpty();
        }
    }
}
