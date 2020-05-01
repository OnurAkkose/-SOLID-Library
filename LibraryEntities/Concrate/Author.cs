using LibraryEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntities.Concrate
{
    public class Author:IEntity
    {

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
    }
}
