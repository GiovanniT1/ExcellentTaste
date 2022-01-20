using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExcellentTasteCore.Data;
using ExcellentTasteCore.Models;

namespace ExcellentTasteCore.Controllers
{
    public class BarmanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarmanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Barman
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Bestelling.Include(b => b.ConsumptieItem).Include(b => b.Reservering).Where(b => b.ConsumptieItemCode == "bi1" || b.ConsumptieItemCode == "bi2" || b.ConsumptieItemCode == "bi3" || b.ConsumptieItemCode == "bi4" || b.ConsumptieItemCode == "bi5" || b.ConsumptieItemCode == "bi6" || b.ConsumptieItemCode == "bi7"
                || b.ConsumptieItemCode == "fi1" || b.ConsumptieItemCode == "fi2" || b.ConsumptieItemCode == "fi3" || b.ConsumptieItemCode == "fi4" || b.ConsumptieItemCode == "fi5" || b.ConsumptieItemCode == "wd1" || b.ConsumptieItemCode == "wd2" || b.ConsumptieItemCode == "wd3" || b.ConsumptieItemCode == "wd4" || b.ConsumptieItemCode == "wd5" || b.ConsumptieItemCode == "wd6" || b.ConsumptieItemCode == "wd7"
                || b.ConsumptieItemCode == "wi1" || b.ConsumptieItemCode == "wi2" || b.ConsumptieItemCode == "wi3" || b.ConsumptieItemCode == "wi4");
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Barman/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bestelling = await _context.Bestelling
                .Include(b => b.ConsumptieItem)
                .Include(b => b.Reservering)
                .FirstOrDefaultAsync(m => m.BestellingId == id);
            if (bestelling == null)
            {
                return NotFound();
            }

            return View(bestelling);
        }
    }
}