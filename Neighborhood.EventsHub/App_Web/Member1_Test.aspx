<%@ Page Language="C#" %>
<%@ Import Namespace="CalendarFeedGenerator" %>   

<script runat="server">
protected void Page_Load(object sender, EventArgs e)
{
    // 1️⃣ prove Global cache exists
    // 1️⃣  prove Global cache exists
var list = (List<EventDto>)Application["Events"];   // now EventDto is in scope
lblGlobal.Text = list == null
    ? "❌ Application[\"Events\"] is null"
    : $"✅ Application cache has {list.Count} events";

// 2️⃣  prove DLL works
// 2️⃣ prove DLL works
string ical = EventIcsBuilder.GenerateICal(
                 list ?? new List<EventDto>());
lblDll.Text = $"✅ GenerateICal returned {ical.Length} characters";


}
</script>

<h2>Member 1 – self‑test page</h2>
<ul>
  <li><asp:Label ID="lblGlobal" runat="server" /></li>
  <li><asp:Label ID="lblDll" runat="server" /></li>
</ul>
<p><a href="Default.aspx">← Back to directory</a></p>
