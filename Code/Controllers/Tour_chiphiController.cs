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
    public class Tour_chiphiController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_chiphiController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_chiphi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_chiphi.ToListAsync());
        }

        // GET: Tour_chiphi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_chiphi = await _context.Tour_chiphi
                .FirstOrDefaultAsync(m => m.chiphi_id == id);
            if (tour_chiphi == null)
            {
                return NotFound();
            }

            return View(tour_chiphi);
        }

        // GET: Tour_chiphi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_chiphi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("chiphi_id,doan_id,chiphi_total,chiphi_chitiet")] Tour_chiphi tour_chiphi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_chiphi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_chiphi);
        }

        // GET: Tour_chiphi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_chiphi = await _context.Tour_chiphi.FindAsync(id);
            if (tour_chiphi == null)
            {
                return NotFound();
            }
            return View(tour_chiphi);
        }

        // POST: Tour_chiphi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("chiphi_id,doan_id,chiphi_total,chiphi_chitiet")] Tour_chiphi tour_chiphi)
        {
            if (id != tour_chiphi.chiphi_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_chiphi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_chiphiExists(tour_chiphi.chiphi_id))
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
            return View(tour_chiphi);
        }

        // GET: Tour_chiphi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_chiphi = await _context.Tour_chiphi
                .FirstOrDefaultAsync(m => m.chiphi_id == id);
            if (tour_chiphi == null)
            {
                return NotFound();
            }

            return View(tour_chiphi);
        }

        // POST: Tour_chiphi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_chiphi = await _context.Tour_chiphi.FindAsync(id);
            _context.Tour_chiphi.Remove(tour_chiphi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_chiphiExists(int id)
        {
            return _context.Tour_chiphi.Any(e => e.chiphi_id == id);
        }
    }
}
