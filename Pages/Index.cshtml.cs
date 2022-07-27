using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace DSD01CalculatorForStudents.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        [Display(Name="First Number")]
        public double NumberA { get; set; }

        [Display(Name = "Second Number")]
        public double NumberB { get; set; }

        [Display(Name = "Result")]
        public double Result { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}