using EDMCRUD.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EDMCRUD.EDM;

namespace EDMCRUD.Models
{
    public class EmployeeService : IEmployeeService
    {
        CompanyEntities dc = new CompanyEntities();
        public List<tblemployee> GetAllEmployees()
        {
            return dc.tblemployees.ToList();
        }

    }
}