using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class Event:IBaseModle
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Repeat { get; set; }
        public int Priority { get; set; }
        public ICollection<EventField> EventFields { get; set; }
        public Template MyTemplate { get; set; }








    }
}
