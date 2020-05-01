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

namespace LibraryBusiness.Concrate
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        [FluentValidationAspect(typeof(BookValidator))]
        public Book Add(Book book)
        {
            //ValidationTool.Validate(new BookValidator(), book);
            return _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
            
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(p => p.BookId == id);
        }

        public Book Update(Book book)
        {
            return _bookDal.Update(book);
        }
    }
}
