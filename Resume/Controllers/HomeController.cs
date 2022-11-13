using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Resume.Data;
using Resume.Models;
using System.Diagnostics;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        // GET: Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // This method is for creating a Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Message")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }
        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}