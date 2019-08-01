using ScreenProject.Interface;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Repository
{
    public class EventFieldRepo : BaseRepo<EventField>, IEventFieldRepo
    {

        public MyAppContext _mYHelperContext;
        public EventFieldRepo(MyAppContext context) : base(context)
        {
            _mYHelperContext = context;

        }

    }
}
