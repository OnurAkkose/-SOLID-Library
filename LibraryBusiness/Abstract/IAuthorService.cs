using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness.Abstract
{
   public interface IAuthorService
    {
        List<Author> GetAll();
        Author GetById(int id);
        Author Add(Author author);
        Author Update(Author author);
        void Delete(Author author);

    }
}
