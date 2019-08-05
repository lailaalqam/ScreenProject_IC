using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.ViewModles
{
    public class EventViewModles
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public DateTime Date { get; set; }

        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; }
        public String Repeat { get; set; }
        public int Priority { get; set; }

        public String BackGround { get; set; }


        public ICollection<EventFieldViewModles> EventFields { get; set; }
        public TemplateViewModles MyTemplate { get; set; }



    }
}
