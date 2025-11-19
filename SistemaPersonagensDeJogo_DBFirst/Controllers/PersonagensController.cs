using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaPersonagensDeJogo_DBFirst.Data;
using SistemaPersonagensDeJogo_DBFirst.Models;

namespace SistemaPersonagensDeJogo_DBFirst.Controllers
{
    public class PersonagensController : Controller
    {
        private readonly AppDbContext _context;

        public PersonagensController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Personagens
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabelaPersonagensFs.ToListAsync());
        }

        // GET: Personagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaPersonagensF = await _context.TabelaPersonagensFs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelaPersonagensF == null)
            {
                return NotFound();
            }

            return View(tabelaPersonagensF);
        }

        // GET: Personagens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Nivel")] TabelaPersonagensF tabelaPersonagensF)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabelaPersonagensF);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabelaPersonagensF);
        }

        // GET: Personagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaPersonagensF = await _context.TabelaPersonagensFs.FindAsync(id);
            if (tabelaPersonagensF == null)
            {
                return NotFound();
            }
            return View(tabelaPersonagensF);
        }

        // POST: Personagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Nivel")] TabelaPersonagensF tabelaPersonagensF)
        {
            if (id != tabelaPersonagensF.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabelaPersonagensF);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabelaPersonagensFExists(tabelaPersonagensF.Id))
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
            return View(tabelaPersonagensF);
        }

        // GET: Personagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaPersonagensF = await _context.TabelaPersonagensFs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelaPersonagensF == null)
            {
                return NotFound();
            }

            return View(tabelaPersonagensF);
        }

        // POST: Personagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabelaPersonagensF = await _context.TabelaPersonagensFs.FindAsync(id);
            if (tabelaPersonagensF != null)
            {
                _context.TabelaPersonagensFs.Remove(tabelaPersonagensF);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabelaPersonagensFExists(int id)
        {
            return _context.TabelaPersonagensFs.Any(e => e.Id == id);
        }
    }
}
