using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using CalendarFeedGenerator;

public class CalendarController : ApiController
{
    [HttpGet, Route("api/calendar")]
    public HttpResponseMessage Get()
    {
        // 1. Grab the cached list (or empty list)
        var events = HttpContext.Current.Application["Events"]
                     as List<EventDto>
                     ?? new List<EventDto>();

        // 2. Build the ICS text
        var ics = EventIcsBuilder.GenerateICal(events);

        // 3. Package it up as a downloadable .ics file
        var msg = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(ics)
        };
        msg.Content.Headers.ContentType =
            new MediaTypeHeaderValue("text/calendar");
        msg.Content.Headers.ContentDisposition =
            new ContentDispositionHeaderValue("attachment")
            {
                FileName = "calendar.ics"
            };

        return msg;
    }
}
