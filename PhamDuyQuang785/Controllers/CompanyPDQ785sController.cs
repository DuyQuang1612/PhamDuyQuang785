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
    public class CompanyPDQ785sController : Controller
    {
        private readonly CompanyPDQ785Context _context;

        public CompanyPDQ785sController(CompanyPDQ785Context context)
        {
            _context = context;
        }

        // GET: CompanyPDQ785s
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyPDQ785.ToListAsync());
        }

        // GET: CompanyPDQ785s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPDQ785 = await _context.CompanyPDQ785
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (companyPDQ785 == null)
            {
                return NotFound();
            }

            return View(companyPDQ785);
        }

        // GET: CompanyPDQ785s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyPDQ785s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName")] CompanyPDQ785 companyPDQ785)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyPDQ785);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyPDQ785);
        }

        // GET: CompanyPDQ785s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPDQ785 = await _context.CompanyPDQ785.FindAsync(id);
            if (companyPDQ785 == null)
            {
                return NotFound();
            }
            return View(companyPDQ785);
        }

        // POST: CompanyPDQ785s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyID,CompanyName")] CompanyPDQ785 companyPDQ785)
        {
            if (id != companyPDQ785.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyPDQ785);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyPDQ785Exists(companyPDQ785.CompanyID))
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
            return View(companyPDQ785);
        }

        // GET: CompanyPDQ785s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPDQ785 = await _context.CompanyPDQ785
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (companyPDQ785 == null)
            {
                return NotFound();
            }

            return View(companyPDQ785);
        }

        // POST: CompanyPDQ785s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyPDQ785 = await _context.CompanyPDQ785.FindAsync(id);
            _context.CompanyPDQ785.Remove(companyPDQ785);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyPDQ785Exists(string id)
        {
            return _context.CompanyPDQ785.Any(e => e.CompanyID == id);
        }
    }
}
