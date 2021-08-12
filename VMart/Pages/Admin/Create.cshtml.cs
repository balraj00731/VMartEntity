using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VMart.Data;
using VMart.Models;

namespace VMart.Pages.Admin
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
        public Login Login { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Login.Email.Equals("Admin@gmail.com") && Login.Password.Equals("12345"))
            {
                return RedirectToPage("./Dashboard");
            }
            else
            {
                return RedirectToPage("./invalid");
            }


        }
    }
}
