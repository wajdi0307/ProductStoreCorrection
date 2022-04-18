using PS.Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Services
{
    public interface IServiceProduct: IService<Product>
    {
        IEnumerable<Product> FindMostExpensiveFiveProds();
    }
}
