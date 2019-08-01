using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class TemplateField
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public String TopPosition { get; set; }
        public String LeftPosition { get; set; }

        public String FontFamily { get; set; }
        public int FontSize { get; set; }
        public String FontColor { get; set; }
        public String Name { get; set; }
        public Template MyTemplate { get; set; }
        public ICollection<EventField> EventFields { get; set; }


       







    }
}
