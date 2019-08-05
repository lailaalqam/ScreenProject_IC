using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.ViewModles
{
    public class TemplateViewModles
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String BackGroundImg { get; set; }
        public ICollection<TemplateFieldViewModles> TemplateFields { get; set; }
        public ICollection<EventViewModles> Events { get; set; }


    }
}
