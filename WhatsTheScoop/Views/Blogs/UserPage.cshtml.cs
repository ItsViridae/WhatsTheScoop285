using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WhatsTheScoop.Data;


namespace WhatsTheScoop.Views.Pages
{
    public class UserPageModel : PageModel
    {
        private readonly DbContext _db;
        
        public UserPageModel(DbContext db)
        {
            _db = db;
        }

        

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _db.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }
            return NotFound();
        }

     
        public ICollection<User> Users { get; set; }
    }
}