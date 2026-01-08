using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class RegistrationService
    {
        private readonly List<Registration> registrations = new();

        public void Register(Registration reg)
        {
            if (!registrations.Any(r => r.EventId == reg.EventId && r.Email == reg.Email))
                registrations.Add(reg);
        }

        public IEnumerable<Registration> GetRegistrations(int eventId) =>
            registrations.Where(r => r.EventId == eventId);
    }
}
