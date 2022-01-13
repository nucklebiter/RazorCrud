using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudWeb.Data;
using RazorCrudWeb.Model;

namespace RazorCrudWeb.Pages.Guests
{
    [BindProperties]

    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        
        public Guest Guest { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {

            Guest = _db.Guest.Find(id);


        }

        public async Task<IActionResult> OnPost(int? id)
        {

            if (ModelState.IsValid)
            {
                 _db.Guest.Update(Guest);
                await _db.SaveChangesAsync();
                TempData["success"] = "Guest Edited Successfully";
                return RedirectToPage("Index");
            }

            return Page();

        }
    }
}
