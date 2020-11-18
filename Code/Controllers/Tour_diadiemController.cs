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
    public class Tour_diadiemController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_diadiemController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_diadiem
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_diadiem.ToListAsync());
        }

        // GET: Tour_diadiem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_diadiem = await _context.Tour_diadiem
                .FirstOrDefaultAsync(m => m.dd_id == id);
            if (tour_diadiem == null)
            {
                return NotFound();
            }

            return View(tour_diadiem);
        }

        // GET: Tour_diadiem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_diadiem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("dd_id,dd_thanhpho,dd_ten,dd_mota")] Tour_diadiem tour_diadiem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_diadiem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_diadiem);
        }

        // GET: Tour_diadiem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_diadiem = await _context.Tour_diadiem.FindAsync(id);
            if (tour_diadiem == null)
            {
                return NotFound();
            }
            return View(tour_diadiem);
        }

        // POST: Tour_diadiem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("dd_id,dd_thanhpho,dd_ten,dd_mota")] Tour_diadiem tour_diadiem)
        {
            if (id != tour_diadiem.dd_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_diadiem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_diadiemExists(tour_diadiem.dd_id))
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
            return View(tour_diadiem);
        }

        // GET: Tour_diadiem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_diadiem = await _context.Tour_diadiem
                .FirstOrDefaultAsync(m => m.dd_id == id);
            if (tour_diadiem == null)
            {
                return NotFound();
            }

            return View(tour_diadiem);
        }

        // POST: Tour_diadiem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_diadiem = await _context.Tour_diadiem.FindAsync(id);
            _context.Tour_diadiem.Remove(tour_diadiem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_diadiemExists(int id)
        {
            return _context.Tour_diadiem.Any(e => e.dd_id == id);
        }
    }
}
