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
    public class IndexModel : PageModel
    {
        private readonly VMart.Data.VMartContext _context;

        public IndexModel(VMart.Data.VMartContext context)
        {
            _context = context;
        }

        public IList<Feedback> Feedback { get;set; }

        public async Task OnGetAsync()
        {
            Feedback = await _context.Feedback.ToListAsync();
        }
    }
}
