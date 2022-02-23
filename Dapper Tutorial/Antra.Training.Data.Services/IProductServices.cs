using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Entity;
namespace Antra.Training.Data.Services
{
    public interface IProductServices
    {
        int InsertProduct (Product product);
        int UpdateProduct (Product product);
        Product GetProduct (int id);
        int DeleteProduct (int id);
        IEnumerable<Product> GetAllProducts ();

    }
}
