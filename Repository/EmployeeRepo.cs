﻿using ScreenProject.Interface;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Repository
{
    public class EmployeeRepo : BaseRepo<Employee>, IEmployeeRepo
    {

        public MyAppContext _mYHelperContext;
        public EmployeeRepo(MyAppContext context) : base(context)
        {
            _mYHelperContext = context;

        }

    }
}
