using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class EventField : IBaseModle
    {
        public int Id { get; set; }

        public int? EventId { get; set; }
       
        public String Value { get; set; }
        public int TemplateFieldId { get; set; }

        public TemplateField MyTemplateField { get; set; }
        public Event MyEvent { get; set; }





    }
}
