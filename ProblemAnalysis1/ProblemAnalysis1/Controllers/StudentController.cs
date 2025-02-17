using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProblemAnalysis1.Models;

namespace ProblemAnalysis1.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationContext _context;

        public StudentController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student.Include(m => m.Program).ToListAsync());
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            ViewBag.Program = _context.Program.OrderBy(g => g.Name).ToList();
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Program = _context.Program.OrderBy(g => g.Name).ToList();
                return View(student);
            }

            _context.Add(student);
            
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            ViewBag.Program = _context.Program.OrderBy(g => g.Name).ToList();
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Program = _context.Program.OrderBy(g => g.Name).ToList();
                return View(student);
            }

            _context.Update(student);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Student.FindAsync(id);
            
            if (student != null)
            {
                _context.Student.Remove(student);
            }

            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }
    }
}
