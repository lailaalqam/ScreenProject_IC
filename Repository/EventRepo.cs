using ScreenProject.Interface;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Repository
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {

        public MyAppContext _mYHelperContext;
        public EventRepo(MyAppContext context) : base(context)
        {
            _mYHelperContext = context;

        }

    }
}
