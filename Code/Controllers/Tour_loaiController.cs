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
    public class Tour_loaiController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_loaiController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_loai
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_loai.ToListAsync());
        }

        // GET: Tour_loai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_loai = await _context.Tour_loai
                .FirstOrDefaultAsync(m => m.loai_id == id);
            if (tour_loai == null)
            {
                return NotFound();
            }

            return View(tour_loai);
        }

        // GET: Tour_loai/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_loai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("loai_id,loai_ten,loai_mota")] Tour_loai tour_loai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_loai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_loai);
        }

        // GET: Tour_loai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_loai = await _context.Tour_loai.FindAsync(id);
            if (tour_loai == null)
            {
                return NotFound();
            }
            return View(tour_loai);
        }

        // POST: Tour_loai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("loai_id,loai_ten,loai_mota")] Tour_loai tour_loai)
        {
            if (id != tour_loai.loai_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_loai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_loaiExists(tour_loai.loai_id))
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
            return View(tour_loai);
        }

        // GET: Tour_loai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_loai = await _context.Tour_loai
                .FirstOrDefaultAsync(m => m.loai_id == id);
            if (tour_loai == null)
            {
                return NotFound();
            }

            return View(tour_loai);
        }

        // POST: Tour_loai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_loai = await _context.Tour_loai.FindAsync(id);
            _context.Tour_loai.Remove(tour_loai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_loaiExists(int id)
        {
            return _context.Tour_loai.Any(e => e.loai_id == id);
        }
    }
}
