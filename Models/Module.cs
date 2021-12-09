using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notenverwaltung.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public int Grade { get; set; }
        public String Name { get; set; }
        public long Weight { get; set;}
    }
}
