using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class Sports_HistoryController : Controller
    {
        private readonly Sports_HistoryContext _context;

        public Sports_HistoryController(Sports_HistoryContext context)
        {
            _context = context;
        }

        // GET: SportsStats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sports_History.ToListAsync());
        }

     }
}