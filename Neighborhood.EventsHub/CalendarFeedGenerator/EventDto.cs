using System;

namespace CalendarFeedGenerator
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public bool IsApproved { get; set; }
    }
}
