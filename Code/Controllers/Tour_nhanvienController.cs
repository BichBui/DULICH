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
    public class Tour_nhanvienController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_nhanvienController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_nhanvien
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_nhanvien.ToListAsync());
        }

        // GET: Tour_nhanvien/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_nhanvien = await _context.Tour_nhanvien
                .FirstOrDefaultAsync(m => m.nv_id == id);
            if (tour_nhanvien == null)
            {
                return NotFound();
            }

            return View(tour_nhanvien);
        }

        // GET: Tour_nhanvien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_nhanvien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nv_id,nv_ten,nv_sdt,nv_ngaysinh,nv_email,nv_nhiemvu")] Tour_nhanvien tour_nhanvien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_nhanvien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_nhanvien);
        }

        // GET: Tour_nhanvien/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_nhanvien = await _context.Tour_nhanvien.FindAsync(id);
            if (tour_nhanvien == null)
            {
                return NotFound();
            }
            return View(tour_nhanvien);
        }

        // POST: Tour_nhanvien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("nv_id,nv_ten,nv_sdt,nv_ngaysinh,nv_email,nv_nhiemvu")] Tour_nhanvien tour_nhanvien)
        {
            if (id != tour_nhanvien.nv_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_nhanvien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_nhanvienExists(tour_nhanvien.nv_id))
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
            return View(tour_nhanvien);
        }

        // GET: Tour_nhanvien/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_nhanvien = await _context.Tour_nhanvien
                .FirstOrDefaultAsync(m => m.nv_id == id);
            if (tour_nhanvien == null)
            {
                return NotFound();
            }

            return View(tour_nhanvien);
        }

        // POST: Tour_nhanvien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_nhanvien = await _context.Tour_nhanvien.FindAsync(id);
            _context.Tour_nhanvien.Remove(tour_nhanvien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_nhanvienExists(int id)
        {
            return _context.Tour_nhanvien.Any(e => e.nv_id == id);
        }
    }
}
