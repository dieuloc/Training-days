using Antra.Training.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Antra.Training.Data.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        IDbConnection dbConnection;
        public ProductRepository()
        {
            dbConnection = new SqlConnection("Data Source=.;Initial Catalog=InventoryDB;Integrated Security=True");
        }

        public int Delete(int id)
        {
            return dbConnection.Execute("Delete from Category where Id = @pid)", new { pid = id });
        }

        public Product Get(int id)
        {
            return dbConnection.QueryFirstOrDefault<Product>("Select Id, ProductName, ProductDiscription, Unit, Price, Status, SupplierId, CategoryId from Product where id=@pid", new { pid = id });
        }

        public IEnumerable<Product> GetAll()
        {
            return dbConnection.Query<Product>("Select Id, ProductName, ProductDiscription, Unit, Price, Status, SupplierId, CategoryId from Product");
        }

        public int Insert(Product entity)
        {
            return dbConnection.Execute("Insert into Product values (@ProductName, @ProductDiscription, @Unit, @Price, @Status, @SupplierId, @CategoryId)", entity);
        }

        public int Update(Product entity)
        {
            return dbConnection.Execute("Update Product set ProdcutName = @ProductName, ProductDiscription = @ProductDiscription, Unit = @Unit, Price = @Price, Status = @Status, SupplierId = @SupplierId, CategoryId = @CategoryId where Id = @Id)", entity);
        }
    }
}
