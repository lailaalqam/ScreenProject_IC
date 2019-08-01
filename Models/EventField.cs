using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class EventField
    {
        public int Id { get; set; }
        public int EventId { get; set; }
       
        public String Value { get; set; }
        public String TemplateFieldId { get; set; }
        public TemplateField MyTemplateField { get; set; }
        public Event MyEvent { get; set; }





    }
}
