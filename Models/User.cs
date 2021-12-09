using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notenverwaltung.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EMail { get; set; }
        public String Password { get; set; }
        public Role Role { get; set; }
/*        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }*/
        public int SchoolClassId { get; set; }
        public SchoolClass SchoolClass { get; set; }

    }
}
