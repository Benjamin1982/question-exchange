
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace questionexchange.Models 
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }

        public void OnGet(string name)
        {
            FullName = name;
            ViewData["heading"] = "  Target !!";

        }
    }


}