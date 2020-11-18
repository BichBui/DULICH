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
    public class Tour_doanController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_doanController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_doan
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_doan.ToListAsync());
        }

        // GET: Tour_doan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_doan = await _context.Tour_doan
                .FirstOrDefaultAsync(m => m.doan_id == id);
            if (tour_doan == null)
            {
                return NotFound();
            }

            return View(tour_doan);
        }

        // GET: Tour_doan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_doan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("doan_id,tour_id,gia_id,doan_name,doan_ngaydi,doan_ngayve,doan_chitietchuongtrinh")] Tour_doan tour_doan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_doan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_doan);
        }

        // GET: Tour_doan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_doan = await _context.Tour_doan.FindAsync(id);
            if (tour_doan == null)
            {
                return NotFound();
            }
            return View(tour_doan);
        }

        // POST: Tour_doan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("doan_id,tour_id,gia_id,doan_name,doan_ngaydi,doan_ngayve,doan_chitietchuongtrinh")] Tour_doan tour_doan)
        {
            if (id != tour_doan.doan_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_doan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_doanExists(tour_doan.doan_id))
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
            return View(tour_doan);
        }

        // GET: Tour_doan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_doan = await _context.Tour_doan
                .FirstOrDefaultAsync(m => m.doan_id == id);
            if (tour_doan == null)
            {
                return NotFound();
            }

            return View(tour_doan);
        }

        // POST: Tour_doan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_doan = await _context.Tour_doan.FindAsync(id);
            _context.Tour_doan.Remove(tour_doan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_doanExists(int id)
        {
            return _context.Tour_doan.Any(e => e.doan_id == id);
        }
    }
}
