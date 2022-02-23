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
    public class CategoryRepository : IRepository<Category>
    {
        IDbConnection dbConnection;
        public CategoryRepository()
        {
            dbConnection = new SqlConnection("Data Source=.;Initial Catalog=InventoryDB;Integrated Security=True");
        }
        public int Delete(int id)
        {
            return dbConnection.Execute("Delete from Category where Id = @cid)", new {cid = id });

        }

        public Category Get(int id)
        {
            return dbConnection.QueryFirstOrDefault<Category>("Select Id, Name, Description from Category where Id = @cid", new {cid = id});
        }

        public IEnumerable<Category> GetAll()
        {
            return dbConnection.Query<Category>("Select Id, Name, Description from Category");
        }

        public int Insert(Category entity)
        {
            return dbConnection.Execute("Insert into Category values (@Name, @Description)", entity);

        }

        public int Update(Category entity)
        {
            return dbConnection.Execute("Update Category set Name = @Name, Description = @Description where Id = @Id", entity);

        }
    }
}
