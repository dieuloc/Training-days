using Antra.Training.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Repository;

namespace Antra.Training.Data.Services
{
    public class CategoryServices : ICategoryServices
    {
        IRepository<Category> _repository;
        public CategoryServices()
        {
            _repository = new CategoryRepository();
        }
        public int DeleteCategory(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _repository.GetAll();
        }

        public Category GetCategory(int id)
        {
            return _repository.Get(id);
        }

        public int InsertCategory(Category category)
        {
            return _repository.Insert(category);
        }

        public int UpdateCategory(Category category)
        {
            return _repository.Update(category);
        }
    }
}
