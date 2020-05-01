using LibraryDataAccess.Abstract;
using LibraryEntities.ComplexTypes;
using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess.Concrate.EntityFramework
{
   public class EfBookDal:EfEntityRepositoryBase<Book,Context>,IBookDal
    {
        //join yapacağım.
        
        /*public List<BookDetail> GetBookDetails()
        {
            using (Context context = new Context())
            {

                var result = from p in context.Books
                             join c in context.Authors on p.BookAuthor equals c.AuthorId
                             select new BookDetail
                             {
                                 BookId=p.BookId,
                                 BookName=p.BookName,
                                 BookAuthor = c.AuthorName
                                 
                             };
                return result.ToList();
            }
        }*/
    }
}
