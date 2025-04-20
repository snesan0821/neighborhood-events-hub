using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using CalendarFeedGenerator;   // DLL project that contains EventDto & EventIcsBuilder

namespace CalendarFeedService.Controllers   // adjust namespace if VS generated a different one
{
    public class CalendarController : ApiController
    {
        // GET  /api/calendar
        [HttpGet, Route("api/calendar")]
        public HttpResponseMessage Get()
        {
            // Pull the cached list that Global.asax put into Application state.
            var events = HttpContext.Current.Application["Events"] as List<EventDto>
                         ?? new List<EventDto>();

            // Build the iCal text
            string ical = EventIcsBuilder.GenerateICal(events);

            // Return it with Content‑Type: text/calendar
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(ical, Encoding.UTF8, "text/calendar")
            };
        }
    }
}
