using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.ViewModles
{
    public class EventFieldViewModles
    {


        public int Id { get; set; }
        public int? EventId { get; set; }
        public String Value { get; set; }
        public int TemplateFieldId { get; set; }
        public TemplateFieldViewModles MyTemplateField { get; set; }
        public EventViewModles MyEvent { get; set; }




    }
}
