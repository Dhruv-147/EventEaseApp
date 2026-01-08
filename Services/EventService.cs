using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<Event> events = new()
        {
            new Event { Id = 1, Name = "Spring Hackathon", Date = new DateTime(2026, 3, 12), Location = "Mumbai", Description = "24 hour coding marathon" },
            new Event { Id = 2, Name = "AI Meetup", Date = new DateTime(2026, 4, 10), Location = "Pune", Description = "Machine Learning talks" },
            new Event { Id = 3, Name = "Design Sprint", Date = new DateTime(2026, 5, 5), Location = "Bangalore", Description = "Rapid prototyping workshop" }
        };

        public Task<List<Event>> GetEventsAsync()
        {
            return Task.FromResult(events);
        }

        public Task<Event?> GetEventByIdAsync(int id)
        {
            return Task.FromResult(events.FirstOrDefault(e => e.Id == id));
        }
    }
}
