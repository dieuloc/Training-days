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
    public class StaffRepository : IRepository<Staff>
    {
        IDbConnection dbConnection;
        public StaffRepository()
        {
            dbConnection = new SqlConnection("Data Source=.;Initial Catalog=InventoryDB;Integrated Security=True");
        }
        public int Delete(int id)
        {
            return dbConnection.Execute("Delete from Staff where Id = @sid)", new { sid = id });
        }

        public Staff Get(int id)
        {
            return dbConnection.QueryFirstOrDefault<Staff>("Select Id, FirstName, LastName, Address, Mobile, EmailId from Staff where Id = @sid", new {sid = id });
        }

        public IEnumerable<Staff> GetAll()
        {
            return dbConnection.Query<Staff>("Select Id, FirstName, LastName, Address, Mobile, EmailId from Staff");
        }

        public int Insert(Staff entity)
        {
            return dbConnection.Execute("Insert into Staff values (@FirstName, @LastName, @Address, @Mobile, @EmailId)", entity);
        }

        public int Update(Staff entity)
        {
            throw new NotImplementedException();
        }
    }
}
