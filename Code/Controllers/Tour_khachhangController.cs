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
    public class Tour_khachhangController : Controller
    {
        private readonly DULICHContext _context;

        public Tour_khachhangController(DULICHContext context)
        {
            _context = context;
        }

        // GET: Tour_khachhang
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tour_khachhang.ToListAsync());
        }

        // GET: Tour_khachhang/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_khachhang = await _context.Tour_khachhang
                .FirstOrDefaultAsync(m => m.kh_id == id);
            if (tour_khachhang == null)
            {
                return NotFound();
            }

            return View(tour_khachhang);
        }

        // GET: Tour_khachhang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tour_khachhang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("kh_id,kh_ten,kh_sdt,kh_ngaysinh,kh_email,kh_cmnd")] Tour_khachhang tour_khachhang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tour_khachhang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tour_khachhang);
        }

        // GET: Tour_khachhang/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_khachhang = await _context.Tour_khachhang.FindAsync(id);
            if (tour_khachhang == null)
            {
                return NotFound();
            }
            return View(tour_khachhang);
        }

        // POST: Tour_khachhang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("kh_id,kh_ten,kh_sdt,kh_ngaysinh,kh_email,kh_cmnd")] Tour_khachhang tour_khachhang)
        {
            if (id != tour_khachhang.kh_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tour_khachhang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tour_khachhangExists(tour_khachhang.kh_id))
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
            return View(tour_khachhang);
        }

        // GET: Tour_khachhang/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tour_khachhang = await _context.Tour_khachhang
                .FirstOrDefaultAsync(m => m.kh_id == id);
            if (tour_khachhang == null)
            {
                return NotFound();
            }

            return View(tour_khachhang);
        }

        // POST: Tour_khachhang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tour_khachhang = await _context.Tour_khachhang.FindAsync(id);
            _context.Tour_khachhang.Remove(tour_khachhang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tour_khachhangExists(int id)
        {
            return _context.Tour_khachhang.Any(e => e.kh_id == id);
        }
    }
}
