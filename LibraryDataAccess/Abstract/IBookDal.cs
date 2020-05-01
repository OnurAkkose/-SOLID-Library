using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess.Abstract
{
    public interface IBookDal:IEntityRepository<Book>
    {

    }
}
