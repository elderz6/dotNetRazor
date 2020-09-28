using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using wwteste1.Models;

namespace wwteste1.Pages.Booklist
{
    public class IndexModel : PageModel{
        private readonly ApplicationDBContext _db;
        public IndexModel(ApplicationDBContext db){
            _db = db;
        }
        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet(){
            Books = await _db.Book.ToListAsync();
        }
    }
}
