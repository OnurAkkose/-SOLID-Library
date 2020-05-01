using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataAccess.Concrate.EntityFramework
{
   public class Context:DbContext
    {
        public Context()
        {
           // Database.SetInitializer<Context>(null);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
