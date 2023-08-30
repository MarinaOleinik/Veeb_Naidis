using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veeb_Naidis.Data;
using Veeb_Naidis.Models;

namespace Veeb_Naidis.Controllers
{
    public class AuthorController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AuthorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public List<Author> PostAuthor([FromBody] Author author)
        {
            _context.ContactDatas.Add(author.Contact);
            _context.SaveChanges();

            author.ContactDataId = author.Contact.Id;

            _context.Authors.Add(author);
            _context.SaveChanges();
            return _context.Authors.Include(a => a.Contact).ToList();
        }
    }
}
