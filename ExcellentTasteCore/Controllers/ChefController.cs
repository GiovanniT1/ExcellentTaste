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
    public class ChefController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChefController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Barman
        public async Task<IActionResult> Index()
        {
            //Filter voor alleen het eten elk nieuwe product moet apart worden toegevoegd via de onderstaande code. 
            //Voorbeeld: b.ConsumptieItemCode == "(ConsumptieItemCode)"
            var applicationDbContext = _context.Bestelling.Include(b => b.ConsumptieItem).Include(b => b.Reservering).Where(b => b.ConsumptieItemCode == "ko1" || b.ConsumptieItemCode == "ko2" || b.ConsumptieItemCode == "ko3" || b.ConsumptieItemCode == "kv1" || b.ConsumptieItemCode == "kv2" || b.ConsumptieItemCode == "kv3" || b.ConsumptieItemCode == "mo1"
                || b.ConsumptieItemCode == "mo2" || b.ConsumptieItemCode == "ve1" || b.ConsumptieItemCode == "ve2" || b.ConsumptieItemCode == "vi1" || b.ConsumptieItemCode == "vi2" || b.ConsumptieItemCode == "vl1" || b.ConsumptieItemCode == "vl2" || b.ConsumptieItemCode == "wa1" || b.ConsumptieItemCode == "wv1" || b.ConsumptieItemCode == "wv2" || b.ConsumptieItemCode == "wv3" || b.ConsumptieItemCode == "wv4"); 
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