using PS.Data;
using PS.Data.Infrastructure;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
    public class ServiceCategory : IServiceCategory
    {
        //PSContext ctx = new PSContext();
        static DataBaseFactory dbf = new DataBaseFactory();
        RepositoryBase<Category> repo = new RepositoryBase<Category>(dbf);

        PSContext ctx = (PSContext)dbf.DataContext;
        public void Add(Category c)
        {
            repo.Add(c);
        }

        public IEnumerable<Category> GetAll()
        {
            return repo.GetMany();

        }

        public void Remove(Category c)
        {
            repo.Delete(c);
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }
    }
}
