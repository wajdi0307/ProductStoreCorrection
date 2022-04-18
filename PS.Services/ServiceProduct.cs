using PS.Data;
using PS.Data.Infrastructure;
using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Services
{
    public class ServiceProduct : Service<Product>, IServiceProduct
    {
        public IEnumerable<Product> FindMostExpensiveFiveProds()
        {
          return  GetMany().OrderByDescending(p => p.Price).Take(5);
        }
    }
}
