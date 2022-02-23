using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Entity;

namespace Antra.Training.Data.Services
{
    public interface ICategoryServices
    {
        int InsertCategory (Category category);
        int UpdateCategory (Category category);
        Category GetCategory (int id);
        int DeleteCategory (int id);
        IEnumerable<Category> GetAllCategory();

    }
}
