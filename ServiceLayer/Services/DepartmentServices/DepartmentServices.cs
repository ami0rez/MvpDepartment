using ServiceLayer.CommunServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;

namespace ServiceLayer.Services.DepartmentServices
{
    public class DepartmentServices : IDepartmentService, IDepartmentRepository
    {
        private IDepartmentRepository _departmentRepository;
        private IModelDataAnotationCheck _modelDataAnnotationCheck;

        public DepartmentServices(IDepartmentRepository departmentRepository, IModelDataAnotationCheck modelDataAnnotationCheck)
        {
            _departmentRepository = departmentRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add(IDepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public void delete(IDepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentModel> getAll()
        {
            throw new NotImplementedException();
        }

        public DepartmentModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IDepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(DepartmentModel departmentModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnotations(departmentModel);
        }
    }
}
