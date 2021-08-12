using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VMart.Data;
using VMart.Models;

namespace VMart.Pages.Query
{
    public class DetailsModel : PageModel
    {
        private readonly VMart.Data.VMartContext _context;

        public DetailsModel(VMart.Data.VMartContext context)
        {
            _context = context;
        }

        public Feedback Feedback { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Feedback = await _context.Feedback.FirstOrDefaultAsync(m => m.id == id);

            if (Feedback == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
