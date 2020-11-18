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
    public class Tour_giaController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_giaController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_gia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_gia.ToListAsync());
        }

        // GET: Tour_gia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_gia = await _context.Tour_gia
                .FirstOrDefaultAsync(m => m.gia_id == id);
            if (tour_gia == null)
            {
                return NotFound();
            }

            return View(tour_gia);
        }

        // GET: Tour_gia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_gia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("gia_id,gia_sotien,tour_id,gia_tungay,gia_denngay")] Tour_gia tour_gia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_gia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_gia);
        }

        // GET: Tour_gia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_gia = await _context.Tour_gia.FindAsync(id);
            if (tour_gia == null)
            {
                return NotFound();
            }
            return View(tour_gia);
        }

        // POST: Tour_gia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("gia_id,gia_sotien,tour_id,gia_tungay,gia_denngay")] Tour_gia tour_gia)
        {
            if (id != tour_gia.gia_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_gia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_giaExists(tour_gia.gia_id))
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
            return View(tour_gia);
        }

        // GET: Tour_gia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_gia = await _context.Tour_gia
                .FirstOrDefaultAsync(m => m.gia_id == id);
            if (tour_gia == null)
            {
                return NotFound();
            }

            return View(tour_gia);
        }

        // POST: Tour_gia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_gia = await _context.Tour_gia.FindAsync(id);
            _context.Tour_gia.Remove(tour_gia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_giaExists(int id)
        {
            return _context.Tour_gia.Any(e => e.gia_id == id);
        }
    }
}
