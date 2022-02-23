using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.Data.Entity;
namespace Antra.Training.Data.Services
{
    public interface IStaffServices
    {
        int InsertStaff(Staff staff);
        int UpdateStaff(Staff staff);
        Staff GetStaff(int id);
        int DeleteStaff(int id);
        IEnumerable<Staff> GetAllStaff();

    }
}
