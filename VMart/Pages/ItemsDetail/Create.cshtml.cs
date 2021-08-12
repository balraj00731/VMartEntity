using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VMart.Data;
using VMart.Models;

namespace VMart.Pages.ItemsDetail
{
    public class CreateModel : PageModel
    {
        private readonly VMart.Data.VMartContext _context;

        public CreateModel(VMart.Data.VMartContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Items Items { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Items.Add(Items);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
