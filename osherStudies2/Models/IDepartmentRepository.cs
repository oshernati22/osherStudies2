﻿using osherStudies2Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace osherStudies2.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
