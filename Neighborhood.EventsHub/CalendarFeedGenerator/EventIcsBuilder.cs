using System.Collections.Generic;
using System.Text;

namespace CalendarFeedGenerator
{
    public static class EventIcsBuilder
    {
        public static string GenerateICal(IEnumerable<EventDto> items)
        {
            var sb = new StringBuilder();
            sb.AppendLine("BEGIN:VCALENDAR").AppendLine("VERSION:2.0");
            foreach (var ev in items)
            {
                sb.AppendLine("BEGIN:VEVENT")
                  .AppendLine($"UID:{ev.Id}@nehub")
                  .AppendLine($"DTSTART:{ev.Date:yyyyMMdd}")
                  .AppendLine($"SUMMARY:{Escape(ev.Title)}")
                  .AppendLine("END:VEVENT");
            }
            sb.AppendLine("END:VCALENDAR");
            return sb.ToString();
        }
        private static string Escape(string t) => t
                .Replace(",", @"\,").Replace(";", @"\;");
    }
}
