﻿using ScreenProject.Interface;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Repository
{
    public class TemplateRepo : BaseRepo<Template>, ITemplateRepo
    {

        public MyAppContext _appContext;
        public TemplateRepo(MyAppContext context) : base(context)
        {
            _appContext = context;

        }

    }
}
