using ScreenProject.Interface;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Repository
{
    public class TemplateFieldRepo : BaseRepo<TemplateField>, ITemplateFieldRepo
    {

        public MyAppContext _appContext;
        public TemplateFieldRepo(MyAppContext context) : base(context)
        {
            _appContext = context;
            _appContext = context;

        }

    }
}
