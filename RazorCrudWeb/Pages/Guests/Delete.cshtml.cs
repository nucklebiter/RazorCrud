using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudWeb.Data;
using RazorCrudWeb.Model;

namespace RazorCrudWeb.Pages.Guests
{
    [BindProperties]

    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        
        public Guest Guest { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {

            Guest = _db.Guest.Find(id);


        }

        public async Task<IActionResult> OnPost()
        {

            
                var guestFromDb = _db.Guest.Find(Guest.GuestId);
                if (guestFromDb != null)
                {

                    _db.Guest.Remove(guestFromDb);
                    await _db.SaveChangesAsync();
                    TempData["success"] = "Guest Deleted Successfully";
                    return RedirectToPage("Index");

                }
                
                
            

            return Page();

        }
    }
}
