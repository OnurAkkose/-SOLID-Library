﻿using LibraryEntities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        Book Add(Book book);
        Book Update(Book book);
        void Delete(Book book);
        
    }
}