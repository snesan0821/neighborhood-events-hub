using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalendarFeedGenerator;    // your DLL namespace

namespace App_Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ==== Simple visits‐cookie counter ====
            int visits = 1;
            HttpCookie existing = Request.Cookies["Visits"];
            if (existing != null && int.TryParse(existing.Value, out var v))
                visits = v + 1;

            var cookie = new HttpCookie("Visits", visits.ToString())
            {
                Expires = DateTime.Now.AddYears(1)
            };
            Response.Cookies.Add(cookie);

            lblVisits.Text = visits.ToString();

            // Clear calendar textbox on first load
            if (!IsPostBack)
                txtCal.Text = string.Empty;
        }

        protected void btnShowCal_Click(object sender, EventArgs e)
        {
            // Get the cached events from Application_Start
            var events = Application["Events"]
                        as List<EventDto>
                        ?? new List<EventDto>();

            // Build the iCal text
            string ics = EventIcsBuilder.GenerateICal(events);

            // Show it inline
            txtCal.Text = ics;
        }
    }
}
