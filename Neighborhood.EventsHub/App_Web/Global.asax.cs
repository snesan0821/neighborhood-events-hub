using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using CalendarFeedGenerator;

namespace App_Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var path = Server.MapPath("~/App_Data/Events.xml");
            List<EventDto> list;

            if (System.IO.File.Exists(path))
            {
                var doc = XDocument.Load(path);
                list = doc.Root?
                        .Elements("Event")
                        .Select(x => new EventDto
                        {
                            Id = (string)x.Element("Id"),
                            Title = (string)x.Element("Title"),
                            Date = DateTime.Parse((string)x.Element("Date"))
                        })
                        .ToList() ?? new List<EventDto>();
            }
            else
            {
                list = new List<EventDto>();
            }

            Application["Events"] = list;
        }
    }
}
