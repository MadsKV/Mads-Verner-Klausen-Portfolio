using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorStart.Data;

namespace RazorStart.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorStart.Data.RazorStartContext _context;

        public IndexModel(RazorStart.Data.RazorStartContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
