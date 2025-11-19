using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaVeiculos_DBFirst.Data;
using SistemaVeiculos_DBFirst.Models;

namespace SistemaVeiculos_DBFirst.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Veiculos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabelaVeiculos.ToListAsync());
        }

        // GET: Veiculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaVeiculo = await _context.TabelaVeiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelaVeiculo == null)
            {
                return NotFound();
            }

            return View(tabelaVeiculo);
        }

        // GET: Veiculos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Modelo,Ano")] TabelaVeiculo tabelaVeiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabelaVeiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tabelaVeiculo);
        }

        // GET: Veiculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaVeiculo = await _context.TabelaVeiculos.FindAsync(id);
            if (tabelaVeiculo == null)
            {
                return NotFound();
            }
            return View(tabelaVeiculo);
        }

        // POST: Veiculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Modelo,Ano")] TabelaVeiculo tabelaVeiculo)
        {
            if (id != tabelaVeiculo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabelaVeiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabelaVeiculoExists(tabelaVeiculo.Id))
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
            return View(tabelaVeiculo);
        }

        // GET: Veiculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaVeiculo = await _context.TabelaVeiculos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabelaVeiculo == null)
            {
                return NotFound();
            }

            return View(tabelaVeiculo);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabelaVeiculo = await _context.TabelaVeiculos.FindAsync(id);
            if (tabelaVeiculo != null)
            {
                _context.TabelaVeiculos.Remove(tabelaVeiculo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabelaVeiculoExists(int id)
        {
            return _context.TabelaVeiculos.Any(e => e.Id == id);
        }
    }
}
