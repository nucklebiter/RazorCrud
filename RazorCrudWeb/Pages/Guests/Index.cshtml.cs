using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudWeb.Data;
using RazorCrudWeb.Model;

namespace RazorCrudWeb.Pages.Guests
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IEnumerable<Guest> Guests { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

            Guests = _db.Guest;

        }
    }
}
