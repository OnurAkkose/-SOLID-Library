using LibraryBusiness.Abstract;
using LibraryBusiness.Concrate;
using LibraryBusiness.Concrate.Manager;
using LibraryDataAccess.Abstract;
using LibraryDataAccess.Concrate.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusiness.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<IAuthorService>().To<AuthorManager>().InSingletonScope();
            Bind<IAuthorDal>().To<EfAuthorDal>().InSingletonScope();
        }
    }
}
