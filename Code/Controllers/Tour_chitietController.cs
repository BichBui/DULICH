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
    public class Tour_chitietController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_chitietController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_chitiet
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_chitiet.ToListAsync());
        }

        // GET: Tour_chitiet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_chitiet = await _context.Tour_chitiet
                .FirstOrDefaultAsync(m => m.ct_id == id);
            if (tour_chitiet == null)
            {
                return NotFound();
            }

            return View(tour_chitiet);
        }

        // GET: Tour_chitiet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_chitiet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ct_id,tour_id,dd_id,ct_thutu")] Tour_chitiet tour_chitiet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_chitiet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_chitiet);
        }

        // GET: Tour_chitiet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_chitiet = await _context.Tour_chitiet.FindAsync(id);
            if (tour_chitiet == null)
            {
                return NotFound();
            }
            return View(tour_chitiet);
        }

        // POST: Tour_chitiet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ct_id,tour_id,dd_id,ct_thutu")] Tour_chitiet tour_chitiet)
        {
            if (id != tour_chitiet.ct_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_chitiet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_chitietExists(tour_chitiet.ct_id))
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
            return View(tour_chitiet);
        }

        // GET: Tour_chitiet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_chitiet = await _context.Tour_chitiet
                .FirstOrDefaultAsync(m => m.ct_id == id);
            if (tour_chitiet == null)
            {
                return NotFound();
            }

            return View(tour_chitiet);
        }

        // POST: Tour_chitiet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_chitiet = await _context.Tour_chitiet.FindAsync(id);
            _context.Tour_chitiet.Remove(tour_chitiet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_chitietExists(int id)
        {
            return _context.Tour_chitiet.Any(e => e.ct_id == id);
        }
    }
}
