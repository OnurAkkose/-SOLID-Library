using LibraryBusiness.Abstract;
using LibraryBusiness.Aspects.Postsharp;
using LibraryBusiness.ValidationRules.FluentValidation;
using LibraryDataAccess.Abstract;
using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness.Concrate.Manager
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;

        }
        [FluentValidationAspect(typeof(AuthorValidator))]
        public Author Add(Author author)
        {
            return _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
           _authorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorDal.Get(p => p.AuthorId == id);
        }

        public Author Update(Author author)
        {
            return _authorDal.Update(author);
        }
    }
}
