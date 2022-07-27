using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.ComponentModel.DataAnnotations;

namespace DSD01CalculatorForStudents.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        [Display(Name = "First Number")]
        public double NumberA { get; set; }

        [Display(Name = "Second Number")]
        public double NumberB { get; set; }

        [Display(Name = "Result")]
        public double Result { get; set; }

        public string? OperationSelection { get; set; }

        [Display(Name = "Operation")]
        public List<SelectListItem> Operations = new List<SelectListItem>
        {
            new SelectListItem { Value = "Add", Text = "Add" },
            new SelectListItem { Value = "Subtract", Text = "Subtract" },
            new SelectListItem { Value = "Multiply", Text = "Multiply" },
            new SelectListItem { Value = "Divide", Text = "Divide" }
        };

        public void OnGet()
        {

        }

        public void OnPost()
        {

           

            if (OperationSelection == "Add")
                Result = NumberA + NumberB;

            if (OperationSelection == "Subtract")
            {
                Result = NumberA - NumberB;
            }
            if (OperationSelection == "Multiply")
            {
                Result = NumberA * NumberB;
            }
            if (OperationSelection == "Divide")
            {
                Result = NumberA / NumberB;
            }


        }
    }
}