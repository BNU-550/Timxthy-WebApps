using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace RazorCurrencyConverter.Pages
{
    public class CConvertModel : PageModel
    {

        public const double GBP_TO_EURO = 1.18;

        [BindProperty]
        public double InputGBP { get; set; }
        [BindProperty]
        public double OutputEUR { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (double.IsNegative(InputGBP))
            {
                ViewData["Message"] = "Cannot enter a negative value!";
            }
            else
            {
                OutputEUR = InputGBP * GBP_TO_EURO;
            }
        }
    }
}