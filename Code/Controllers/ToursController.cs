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
    public class ToursController : Controller
    {
        private readonly DULICHContext _context;

        public ToursController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tours
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tours.ToListAsync());
        }

        // GET: Tours/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tours = await _context.Tours
                .FirstOrDefaultAsync(m => m.tour_id == id);
            if (tours == null)
            {
                return NotFound();
            }

            return View(tours);
        }

        // GET: Tours/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("tour_id,tour_ten,tour_mota,loai_id")] Tours tours)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tours);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tours);
        }

        // GET: Tours/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tours = await _context.Tours.FindAsync(id);
            if (tours == null)
            {
                return NotFound();
            }
            return View(tours);
        }

        // POST: Tours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("tour_id,tour_ten,tour_mota,loai_id")] Tours tours)
        {
            if (id != tours.tour_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tours);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToursExists(tours.tour_id))
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
            return View(tours);
        }

        // GET: Tours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tours = await _context.Tours
                .FirstOrDefaultAsync(m => m.tour_id == id);
            if (tours == null)
            {
                return NotFound();
            }

            return View(tours);
        }

        // POST: Tours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tours = await _context.Tours.FindAsync(id);
            _context.Tours.Remove(tours);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToursExists(int id)
        {
            return _context.Tours.Any(e => e.tour_id == id);
        }
        
    }
}
