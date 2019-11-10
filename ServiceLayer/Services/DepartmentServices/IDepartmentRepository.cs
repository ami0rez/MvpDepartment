using DomainLayer.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.DepartmentServices
{
    public  interface IDepartmentRepository
    {
        IEnumerable<DepartmentModel> getAll();
        DepartmentModel GetById(int id);
        void Add(IDepartmentModel departmentModel);
        void Update(IDepartmentModel departmentModel);
        void delete(IDepartmentModel departmentModel);
    }
}
