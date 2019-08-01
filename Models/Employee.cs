using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public String JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public String Status { get; set; }
        public String Email { get; set; }
        public DateTime DOB { get; set; }

    }
}
