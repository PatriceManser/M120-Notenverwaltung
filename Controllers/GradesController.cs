using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Notenverwaltung.Data;
using Notenverwaltung.Models;

namespace Notenverwaltung
{
    public class GradesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GradesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Grades of specific User
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null || _context.Users.FirstOrDefault(user => user.UserId == id) == null)
            {
                return NotFound();
            }
            else { 
                return View(await _context.Users.FirstOrDefaultAsync(user => user.UserId == id)); 
            }
        }

    }
}
