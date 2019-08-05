using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.ViewModles
{
    public class EventListViewModle
    {


        public String BackGround { get; set; }
        public String TopPosition { get; set; }
        public String LeftPosition { get; set; }
        public String FontFamily { get; set; }
        public int FontSize { get; set; }
        public int FontWeight { get; set; }
        public int FontStyle { get; set; }

        public String FontColor { get; set; }
        public ICollection<EventFieldViewModles> EventFields { get; set; }
        public TemplateViewModles MyTemplate { get; set; }



    }
}
