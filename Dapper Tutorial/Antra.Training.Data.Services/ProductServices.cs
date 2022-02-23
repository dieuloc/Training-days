using Antra.Training.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Repository;

namespace Antra.Training.Data.Services
{
    internal class ProductServices : IProductServices
    {
        IRepository<Product> _repository;
        public ProductServices()
        {
            _repository = new ProductRepository();
        }
        public int DeleteProduct(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _repository.Get(id);
        }

        public int InsertProduct(Product product)
        {
            return _repository.Insert(product);
        }

        public int UpdateProduct(Product product)
        {
            return _repository.Update(product);
        }
    }
}
