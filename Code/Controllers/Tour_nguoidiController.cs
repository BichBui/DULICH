using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DULICH.Data;
using DULICH.Models;

namespace DULICH.Controllers
{
    public class Tour_nguoidiController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_nguoidiController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_nguoidi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_nguoidi.ToListAsync());
        }

        // GET: Tour_nguoidi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_nguoidi = await _context.Tour_nguoidi
                .FirstOrDefaultAsync(m => m.nguoidi_id == id);
            if (tour_nguoidi == null)
            {
                return NotFound();
            }

            return View(tour_nguoidi);
        }

        // GET: Tour_nguoidi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_nguoidi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nguoidi_id,doan_id,nguoidi_dsnhanvien,nguoidi_dskhach")] Tour_nguoidi tour_nguoidi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_nguoidi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_nguoidi);
        }

        // GET: Tour_nguoidi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_nguoidi = await _context.Tour_nguoidi.FindAsync(id);
            if (tour_nguoidi == null)
            {
                return NotFound();
            }
            return View(tour_nguoidi);
        }

        // POST: Tour_nguoidi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("nguoidi_id,doan_id,nguoidi_dsnhanvien,nguoidi_dskhach")] Tour_nguoidi tour_nguoidi)
        {
            if (id != tour_nguoidi.nguoidi_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_nguoidi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_nguoidiExists(tour_nguoidi.nguoidi_id))
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
            return View(tour_nguoidi);
        }

        // GET: Tour_nguoidi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_nguoidi = await _context.Tour_nguoidi
                .FirstOrDefaultAsync(m => m.nguoidi_id == id);
            if (tour_nguoidi == null)
            {
                return NotFound();
            }

            return View(tour_nguoidi);
        }

        // POST: Tour_nguoidi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_nguoidi = await _context.Tour_nguoidi.FindAsync(id);
            _context.Tour_nguoidi.Remove(tour_nguoidi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_nguoidiExists(int id)
        {
            return _context.Tour_nguoidi.Any(e => e.nguoidi_id == id);
        }
    }
}
