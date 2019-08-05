using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Interface
{
     public interface IEventRepo : IBaseRepo<Event>
    {

         DateTime GetALL();
        List<Event> GetAnnualMonthlyDailyAndOnce();
        List<Event> GetAllAnnual();
        List<Event> GetAllDaily();
        List<Event> GetAllMonthly();
        List<Event> GetAllOnce();



    }
}
