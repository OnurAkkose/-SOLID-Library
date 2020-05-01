using LibraryEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities.Concrate
{
    public class Book:IEntity
    {

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
    }
}
