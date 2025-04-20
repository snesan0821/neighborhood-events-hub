using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using CalendarFeedGenerator;
using System.Web.Http;


namespace App_Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Physical path to App_Data/Events.xml
            string xmlPath = Path.Combine(
                HttpRuntime.AppDomainAppPath, @"App_Data\Events.xml");

            // if file missing create an empty root so app doesn't crash
            if (!File.Exists(xmlPath))
            {
                File.WriteAllText(xmlPath, "<?xml version=\"1.0\"?><Events></Events>");
            }

            // Load into memory
            XDocument doc = XDocument.Load(xmlPath);

            var events = doc.Root
                            .Elements("Event")
                            .Select(x => new EventDto
                            {
                                Id = (int)x.Element("Id"),
                                Title = (string)x.Element("Title"),
                                Date = DateTime.Parse(
                                        ((string)x.Element("Date")) + " " +
                                        ((string)x.Element("Time") ?? "00:00")),
                                Address = (string)x.Element("Address"),
                                IsApproved = (bool?)x.Element("IsApproved") ?? false
                            })
                            .ToList();

            // cache in Application scope
            Application["Events"] = events;

            GlobalConfiguration.Configure(CalendarFeedService.WebApiConfig.Register);
        }
    }
}