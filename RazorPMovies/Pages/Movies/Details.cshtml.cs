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
    public class DetailsModel : PageModel
    {
        private readonly RazorPMovies.Data _context;

        public DetailsModel(RazorPMovies.Data context)
        {
            _context = context;
        }

        public Movies Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);

            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}