using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = "";

        [Required]
        public DateTime Date { get; set; }

        [Required, StringLength(100)]
        public string Location { get; set; } = "";

        public string? Description { get; set; }
    }
}
