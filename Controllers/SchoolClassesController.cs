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
    public class SchoolClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchoolClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SchoolClasses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SchoolClass.Include(s => s.Profession);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SchoolClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schoolClass = await _context.SchoolClass
                .Include(s => s.Profession)
                .FirstOrDefaultAsync(m => m.SchoolClassId == id);
            if (schoolClass == null)
            {
                return NotFound();
            }

            return View(schoolClass);
        }

        // GET: SchoolClasses/Create
        public IActionResult Create()
        {
            ViewData["ProfessionId"] = new SelectList(_context.Profession, "ProfessionId", "ProfessionId");
            return View();
        }

        // POST: SchoolClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SchoolClassId,Name,ProfessionId")] SchoolClass schoolClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schoolClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfessionId"] = new SelectList(_context.Profession, "ProfessionId", "ProfessionId", schoolClass.ProfessionId);
            return View(schoolClass);
        }

        // GET: SchoolClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schoolClass = await _context.SchoolClass.FindAsync(id);
            if (schoolClass == null)
            {
                return NotFound();
            }
            ViewData["ProfessionId"] = new SelectList(_context.Profession, "ProfessionId", "ProfessionId", schoolClass.ProfessionId);
            return View(schoolClass);
        }

        // POST: SchoolClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SchoolClassId,Name,ProfessionId")] SchoolClass schoolClass)
        {
            if (id != schoolClass.SchoolClassId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schoolClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolClassExists(schoolClass.SchoolClassId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfessionId"] = new SelectList(_context.Profession, "ProfessionId", "ProfessionId", schoolClass.ProfessionId);
            return View(schoolClass);
        }

        // GET: SchoolClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schoolClass = await _context.SchoolClass
                .Include(s => s.Profession)
                .FirstOrDefaultAsync(m => m.SchoolClassId == id);
            if (schoolClass == null)
            {
                return NotFound();
            }

            return View(schoolClass);
        }

        // POST: SchoolClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schoolClass = await _context.SchoolClass.FindAsync(id);
            _context.SchoolClass.Remove(schoolClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolClassExists(int id)
        {
            return _context.SchoolClass.Any(e => e.SchoolClassId == id);
        }
    }
}
