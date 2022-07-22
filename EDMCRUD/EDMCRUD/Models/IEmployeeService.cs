using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDMCRUD.EDM;

namespace EDMCRUD.Models
{
    interface IEmployeeService
    {
        List<tblemployee> GetAllEmployees();

    }
}
