using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VMart.Data;
using VMart.Models;

namespace VMart.Pages.Admin
{
    public class DetailsModel : PageModel
    {
        private readonly VMart.Data.VMartContext _context;

        public DetailsModel(VMart.Data.VMartContext context)
        {
            _context = context;
        }

        public Login Login { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Login = await _context.Login.FirstOrDefaultAsync(m => m.Id == id);

            if (Login == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
