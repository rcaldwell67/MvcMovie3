using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsData.Data;
using SportsData.Models;
using System;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SportsData.Controllers
{
    public class SportsStatsController : Controller
    {
        private readonly SportsStatsContext _context;

        public SportsStatsController(SportsStatsContext context)
        {
            _context = context;
        }

        // GET: SportsStats
        public async Task<IActionResult> Index()
        {
            return View(await _context.SportsStats.ToListAsync());
        }

        // 
        // GET: /HelloWorld/

        //public IActionResult Index()
        //{
        //    return View();
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

    }
}