using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Model
{
    public class Town:Entity
    {
        public string Name { get; set; }
        public bool Capital { get; set; }
        public Country Country { get; set; }
        public Guid CountryId { get; set; }

    }
}
