﻿using DomainLayer.Models.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        void ValidateModel(DepartmentModel departmentModel);
    }
}
