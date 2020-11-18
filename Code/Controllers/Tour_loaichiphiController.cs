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
    public class Tour_loaichiphiController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_loaichiphiController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_loaichiphi
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_loaichiphi.ToListAsync());
        }

        // GET: Tour_loaichiphi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_loaichiphi = await _context.Tour_loaichiphi
                .FirstOrDefaultAsync(m => m.cp_id == id);
            if (tour_loaichiphi == null)
            {
                return NotFound();
            }

            return View(tour_loaichiphi);
        }

        // GET: Tour_loaichiphi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_loaichiphi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cp_id,cp_ten,cp_mota")] Tour_loaichiphi tour_loaichiphi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_loaichiphi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_loaichiphi);
        }

        // GET: Tour_loaichiphi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_loaichiphi = await _context.Tour_loaichiphi.FindAsync(id);
            if (tour_loaichiphi == null)
            {
                return NotFound();
            }
            return View(tour_loaichiphi);
        }

        // POST: Tour_loaichiphi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cp_id,cp_ten,cp_mota")] Tour_loaichiphi tour_loaichiphi)
        {
            if (id != tour_loaichiphi.cp_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_loaichiphi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_loaichiphiExists(tour_loaichiphi.cp_id))
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
            return View(tour_loaichiphi);
        }

        // GET: Tour_loaichiphi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_loaichiphi = await _context.Tour_loaichiphi
                .FirstOrDefaultAsync(m => m.cp_id == id);
            if (tour_loaichiphi == null)
            {
                return NotFound();
            }

            return View(tour_loaichiphi);
        }

        // POST: Tour_loaichiphi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_loaichiphi = await _context.Tour_loaichiphi.FindAsync(id);
            _context.Tour_loaichiphi.Remove(tour_loaichiphi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_loaichiphiExists(int id)
        {
            return _context.Tour_loaichiphi.Any(e => e.cp_id == id);
        }
    }
}
