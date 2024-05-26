using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PoetryWebsite.Data;
using PoetryWebsite.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PoetryWebsite.Controllers
{
    public class PoetryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PoetryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var poems = _context.Poetries.ToList();
            return View(poems);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Author,Content")] Poetry poetry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poetry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poetry);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var poetry = await _context.Poetries.FindAsync(id);
            if (poetry == null)
            {
                return NotFound();
            }

            _context.Poetries.Remove(poetry);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}