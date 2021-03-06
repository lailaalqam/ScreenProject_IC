﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class Event:IBaseModle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public DateTime Date { get; set; }

        public TimeSpan StartDate { get; set; }
        public TimeSpan EndDate { get; set; }
        public String Repeat { get; set; }
        public int Priority { get; set; }
        public ICollection<EventField> EventFields { get; set; }
        public Template MyTemplate { get; set; }








    }
}
