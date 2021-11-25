using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPMovies;
using RazorPMovies.Models;

namespace RazorPMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPMovies.Data _context;

        public IndexModel(RazorPMovies.Data context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
