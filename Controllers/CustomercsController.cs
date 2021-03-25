using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KhehraReasturant.Data;
using KhehraReasturant.Models;
using Microsoft.AspNetCore.Authorization;

namespace KhehraReasturant.Controllers
{
    [Authorize]
    public class CustomercsController : Controller
    {
        private readonly OrdersDbContext _context;

        public CustomercsController(OrdersDbContext context)
        {
            _context = context;
        }

        // GET: Customercs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customercs.ToListAsync());
        }

        // GET: Customercs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customercs = await _context.Customercs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customercs == null)
            {
                return NotFound();
            }

            return View(customercs);
        }

        // GET: Customercs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customercs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,Surname,Phone,Address")] Customercs customercs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customercs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customercs);
        }

        // GET: Customercs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customercs = await _context.Customercs.FindAsync(id);
            if (customercs == null)
            {
                return NotFound();
            }
            return View(customercs);
        }

        // POST: Customercs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,Surname,Phone,Address")] Customercs customercs)
        {
            if (id != customercs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customercs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomercsExists(customercs.ID))
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
            return View(customercs);
        }

        // GET: Customercs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customercs = await _context.Customercs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customercs == null)
            {
                return NotFound();
            }

            return View(customercs);
        }

        // POST: Customercs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customercs = await _context.Customercs.FindAsync(id);
            _context.Customercs.Remove(customercs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomercsExists(int id)
        {
            return _context.Customercs.Any(e => e.ID == id);
        }
    }
}
