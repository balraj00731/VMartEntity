using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VMart.Data;
using VMart.Models;

namespace VMart.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        private readonly VMart.Data.VMartContext _context;

        public DetailsModel(VMart.Data.VMartContext context)
        {
            _context = context;
        }

        public Sales Sales { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sales = await _context.Sales.FirstOrDefaultAsync(m => m.Id == id);

            if (Sales == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
