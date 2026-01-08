namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        private readonly Dictionary<int, HashSet<string>> attendance = new();

        public void MarkPresent(int eventId, string email)
        {
            if (!attendance.ContainsKey(eventId))
                attendance[eventId] = new HashSet<string>();

            attendance[eventId].Add(email);
        }

        public int Count(int eventId) =>
            attendance.ContainsKey(eventId) ? attendance[eventId].Count : 0;
    }
}
