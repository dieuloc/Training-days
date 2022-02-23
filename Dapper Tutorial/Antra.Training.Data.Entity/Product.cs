using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.Data.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductDiscription { get; set; }
        public string? Unit { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public int SupplierId { get; set; }
        public int categoryId { get; set; }

    }
}
