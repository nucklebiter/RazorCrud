using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudWeb.Data;
using RazorCrudWeb.Model;

namespace RazorCrudWeb.Pages.Guests
{
    [BindProperties]

    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        
        public Guest Guest { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                await _db.Guest.AddAsync(Guest);
                await _db.SaveChangesAsync();
                TempData["success"] = "Guest Created Successfully";
                return RedirectToPage("Index");
            }

            return Page();

        }
    }
}
