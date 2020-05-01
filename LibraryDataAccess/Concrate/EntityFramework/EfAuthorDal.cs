using LibraryDataAccess.Abstract;
using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess.Concrate.EntityFramework
{
    public class EfAuthorDal : EfEntityRepositoryBase<Author, Context>, IAuthorDal
    {
    }
}
