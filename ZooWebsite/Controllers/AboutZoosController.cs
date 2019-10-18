using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooWebsite.Models;
using ZooWebsite.ZooContext;

namespace ZooWebsite.Controllers
{
    public class AboutZoosController : Controller
    {
        private readonly EFDataContext _context;

        public AboutZoosController(EFDataContext context)
        {
            _context = context;
        }

        // GET: AboutZoos
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutZoos.ToListAsync());
        }

        // GET: AboutZoos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutZoo = await _context.AboutZoos
                .FirstOrDefaultAsync(m => m.AboutZooID == id);
            if (aboutZoo == null)
            {
                return NotFound();
            }

            return View(aboutZoo);
        }

        // GET: AboutZoos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AboutZoos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AboutZooID,Description,Date")] AboutZoo aboutZoo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutZoo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutZoo);
        }

        // GET: AboutZoos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutZoo = await _context.AboutZoos.FindAsync(id);
            if (aboutZoo == null)
            {
                return NotFound();
            }
            return View(aboutZoo);
        }

        // POST: AboutZoos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AboutZooID,Description,Date")] AboutZoo aboutZoo)
        {
            if (id != aboutZoo.AboutZooID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutZoo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutZooExists(aboutZoo.AboutZooID))
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
            return View(aboutZoo);
        }

        // GET: AboutZoos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutZoo = await _context.AboutZoos
                .FirstOrDefaultAsync(m => m.AboutZooID == id);
            if (aboutZoo == null)
            {
                return NotFound();
            }

            return View(aboutZoo);
        }

        // POST: AboutZoos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutZoo = await _context.AboutZoos.FindAsync(id);
            _context.AboutZoos.Remove(aboutZoo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutZooExists(int id)
        {
            return _context.AboutZoos.Any(e => e.AboutZooID == id);
        }
    }
}
