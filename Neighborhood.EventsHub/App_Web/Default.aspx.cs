using System;
using System.Collections.Generic;
using CalendarFeedGenerator;   // DLL project with EventDto & EventIcsBuilder

namespace App_Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: any initialisation when the page first loads
        }

        // Try‑It button click handler
        protected void btnShowCal_Click(object sender, EventArgs e)
        {
            // Get the cached list created in Global.asax (may be null/empty)
            var list = Application["Events"] as List<EventDto> ?? new List<EventDto>();

            // Generate iCal text and show it in the textbox
            txtCal.Text = EventIcsBuilder.GenerateICal(list);
        }
    }
}
