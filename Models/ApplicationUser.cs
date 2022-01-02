﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notenverwaltung.Models
{
    public class ApplicationUser :IdentityUser
    {
        public int UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int? SchoolClassId { get; set; }
        public SchoolClass? SchoolClass { get; set; }

    }
}
