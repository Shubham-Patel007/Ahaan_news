using AhaanNews.Data;
using AhaanNews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AhaanNews.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public NewsController(ApplicationDbContext context) => _context = context;


        [HttpGet]
        public async Task<IActionResult> GetNews() =>
        Ok(await _context.News.ToListAsync());
    }
}
