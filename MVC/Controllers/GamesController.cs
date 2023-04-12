using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class GamesController : Controller
    {
        private readonly MVCContext _context;

        public GamesController(MVCContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            return View(Enumerable.Empty<Game>());
        }       
        
        // GET: Games
        public async Task<IActionResult> GamesJson()
        {
            return Json(await _context.Game.Select(g => new { g.Title, g.ReleaseDate, g.Genre, g.Price }).ToListAsync());
        }
    }
}
