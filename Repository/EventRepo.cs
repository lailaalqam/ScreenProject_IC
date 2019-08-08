using Microsoft.EntityFrameworkCore;
using ScreenProject.Interface;
using ScreenProject.Models;
using ScreenProject.ViewModles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Repository
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {

        public MyAppContext _appContext;
        public EventRepo(MyAppContext context) : base(context)
        {
            _appContext = context;

        }

        public DateTime GetALL()
        {
            DateTime CurentDate = DateTime.UtcNow.Date;
            Console.WriteLine(CurentDate.ToString("d"));
            Console.WriteLine(CurentDate.ToString("dd/MM"));
           
            return CurentDate;
            
        }
        public List<Event> GetAllAnnual()
        {

            DateTime dateTime = DateTime.Now;
            string annual = dateTime.ToString("dd/MM");

            return _appContext.Events.Where(c => (c.StartDate.ToString("dd/MM") == annual) && (c.Repeat == "annual")).ToList();

        }
        public List<Event> GetAnnualMonthlyDailyAndOnce()
        {
            DateTime dateTime = DateTime.Now;
            string annual = dateTime.ToString("dd/MM");
            string monthly = dateTime.ToString("dd");
            string daily = dateTime.ToString("");
            string once = dateTime.ToString("dd / MM / yyyy");

            return _appContext.Events.Include(c => c.MyTemplate).ThenInclude(t => t.TemplateFields)
               .Include(c => c.EventFields)
                .Where(c => ((c.Date.ToString("dd/MM") == dateTime.ToString("dd/MM")) 
                && (c.Repeat == "annual")) || ((c.Date.ToString("dd") == monthly)
                && (c.Repeat == "monthly")) || ((c.Repeat == "daily")) || ((c.Date.ToString("dd / MM / yyyy") == once) 
                && (c.Repeat == "once"))).ToList();
        }
            public List<Event> GetAllDaily()
        {

            DateTime dateTime = DateTime.Now;
            string daily = dateTime.ToString("dd/MM/yyyy");

            return _appContext.Events.Include(c => c.MyTemplate).Where(c =>  (c.Repeat == "daily")).ToList();

        }


        public List<Event> GetAllMonthly()
        {

            DateTime dateTime = DateTime.Now;
            string Monthly = dateTime.ToString("dd");

            return _appContext.Events.Include(c => c.MyTemplate).Where(c => (c.StartDate.ToString("dd") == Monthly) && (c.Repeat == "monthly")).ToList();

        }

        public List<Event> GetAllOnce()
        {

            DateTime dateTime = DateTime.Now;
            string Once = dateTime.ToString("dd/MM/yyyy");

            return _appContext.Events.Include(c=>c.MyTemplate).Where(c => (c.StartDate.ToString("dd/MM/yyyy") == Once) && (c.Repeat == "Once")).ToList();

        }





    }
}
