﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThiYNhi.DTO.Employee
{
    public class DepartmentDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<EmployeeDTO> Customers { get; set; }
    }
}
