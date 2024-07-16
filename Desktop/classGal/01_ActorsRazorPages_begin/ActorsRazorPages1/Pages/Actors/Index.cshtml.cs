using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ActorsRazorPages1.Pages.Models; //------------------------
//using ActorsRazorPages1.Models;

namespace ActorsRazorPages1.Pages.Actors
{
    public class IndexModel : PageModel
    {
        private readonly IData _data;

        public IndexModel(IData data)
        {
            _data = data;  // Initialize _data field with the data parameter
        }

        // Property to hold list of actors
        public IList<Actor> Actors { get; set; }

        public void OnGet()
        {
            // Initialize Actors property using ActorsInitializeData method of _data field
            Actors = _data.ActorsInitializeData();
        }
    }
}
