﻿using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            //return _context.Department.ToList();
            return _context.Department.OrderBy(dep => dep.Name).ToList();
        }
    }
}
