using System.ComponentModel.DataAnnotations;

namespace RazorCrudWeb.Model
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        [Required]
        [Display(Name ="Guest First Name")]
        public string GuestFirstName { get; set; }
        [Required]
        [Display(Name = "Guest Last Name")]
        public string GuestLastName { get; set; }
        [Display(Name = "Guest Email")]
        public string GuestEmail { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Guest Note")]
        [MinLength(1)]
        [MaxLength(200,ErrorMessage = "Value Is To Long")]
        public string GuestNote { get; set; }

    }
}
