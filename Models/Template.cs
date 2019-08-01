using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class Template : IBaseModle
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String BackGroundImg { get; set; }
        public ICollection<TemplateField> TemplateFields { get; set; }
        public ICollection<Event> Events { get; set; }





    }
}
