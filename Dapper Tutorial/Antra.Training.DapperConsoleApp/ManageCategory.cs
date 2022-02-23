using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Services;

namespace Antra.Training.DapperConsoleApp
{
    internal class ManageCategory
    {
        ICategoryServices categoryServices;
        public ManageCategory()
        {
            categoryServices = new CategoryServices();
        }

        void PrintAllCategory()
        {
            var collection = categoryServices.GetAllCategory();
            
            if(collection != null)
            {
                foreach(var item in collection)
                {
                    Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Description}");
                }
            }
        }

        public void Run()
        {
            PrintAllCategory();
        }
    }
}
