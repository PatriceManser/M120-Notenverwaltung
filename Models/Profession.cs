using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notenverwaltung.Models
{
    public class Profession
    {
        public int ProfessionId { get; set; }
        public List<Module> Modules { get; set; }
    }
}
