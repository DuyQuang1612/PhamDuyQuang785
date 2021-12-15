using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamDuyQuang785.Models;

namespace PhamDuyQuang785.Controllers
{
    public class PDQ0785sController : Controller
    {
        private readonly CompanyPDQ785Context _context;

        public PDQ0785sController(CompanyPDQ785Context context)
        {
            _context = context;
        }

        // GET: PDQ0785s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PDQ0785.ToListAsync());
        }

        // GET: PDQ0785s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDQ0785 = await _context.PDQ0785
                .FirstOrDefaultAsync(m => m.PDQid == id);
            if (pDQ0785 == null)
            {
                return NotFound();
            }

            return View(pDQ0785);
        }

        // GET: PDQ0785s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PDQ0785s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PDQid,PDQName,PDQgender")] PDQ0785 pDQ0785)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pDQ0785);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pDQ0785);
        }

        // GET: PDQ0785s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDQ0785 = await _context.PDQ0785.FindAsync(id);
            if (pDQ0785 == null)
            {
                return NotFound();
            }
            return View(pDQ0785);
        }

        // POST: PDQ0785s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PDQid,PDQName,PDQgender")] PDQ0785 pDQ0785)
        {
            if (id != pDQ0785.PDQid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pDQ0785);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PDQ0785Exists(pDQ0785.PDQid))
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
            return View(pDQ0785);
        }

        // GET: PDQ0785s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDQ0785 = await _context.PDQ0785
                .FirstOrDefaultAsync(m => m.PDQid == id);
            if (pDQ0785 == null)
            {
                return NotFound();
            }

            return View(pDQ0785);
        }

        // POST: PDQ0785s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pDQ0785 = await _context.PDQ0785.FindAsync(id);
            _context.PDQ0785.Remove(pDQ0785);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PDQ0785Exists(string id)
        {
            return _context.PDQ0785.Any(e => e.PDQid == id);
        }
    }
}
