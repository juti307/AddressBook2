using AddressBookPS02.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookPS02.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty] //przypinamy by był to element przesyłany w postcie, z domyślnymi ustawieniami
        public Address Address { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
        public IActionResult OnPost() //metoda on post
        {
            if (!ModelState.IsValid) //czy typ jest zgodny
            {
                return Page(); //zostań na tej stronie
            }
            return RedirectToPage("./Privacy"); // przejdź do strony Privaacy
        }
    }
}
