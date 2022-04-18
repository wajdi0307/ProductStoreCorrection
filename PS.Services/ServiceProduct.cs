using PS.Data;
using PS.Data.Infrastructure;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
    public class ServiceProduct : IServiceProduct
    {
        // PSContext ctx = new PSContext();
        static DataBaseFactory dbf = new DataBaseFactory();
        // RepositoryBase<Product> repo = new RepositoryBase<Product>(dbf);
        UnitOfWork uow = new UnitOfWork(dbf);
        //PSContext ctx = (PSContext)dbf.DataContext;

        public void Add(Product p)
        {
           uow.getRepository<Product>().Add(p);
        }


        public IEnumerable<Product> GetAll()
        {
            return uow.getRepository<Product>().GetMany();
        }

        public void Remove(Product p)
        {
            uow.getRepository<Product>().Delete(p);
        }

        public void Commit()
        {
            uow.Commit();
        }
    }
}
