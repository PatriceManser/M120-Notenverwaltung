using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notenverwaltung.Models
{
    public class SchoolClass
    {
        public int SchoolClassId { get; set; }
        public String Name { get; set; }
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
