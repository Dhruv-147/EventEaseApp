using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Registration
    {
        public int EventId { get; set; }

        [Required, StringLength(60, MinimumLength = 3)]
        public string Name { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";
    }
}
