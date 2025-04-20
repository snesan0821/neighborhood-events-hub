<%@ Page Title="Home Page"
         Language="C#"
         MasterPageFile="~/Site.Master"
         AutoEventWireup="true"
         CodeBehind="Default.aspx.cs"
         Inherits="App_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <main class="container">

    <!-- ======= Header & Instructions ======= -->
    <section class="row" aria-labelledby="appTitle">
      <h1 id="appTitle">Neighborhood Events Hub – Calendar Demo</h1>
      <p class="lead">
        This public page shows how our site can publish neighborhood events as
        an iCalendar feed (<code>.ics</code>).
        <ul>
          <li>Click <strong>Show Calendar Text</strong> to view the feed inline.</li>
          <li>Click <strong>Download .ics</strong> to save the file.</li>
          <li>Test events are loaded from <em>App_Data/Events.xml</em>.</li>
        </ul>
      </p>
    </section>
    <hr />

    <!-- ======= Member / Staff navigation ======= -->
    <div class="mb-4">
      <a class="btn btn-info me-2" href="Member.aspx">Member Page</a>
      <a class="btn btn-warning" href="Staff.aspx">Staff Page</a>
      &nbsp;|&nbsp; Visits this browser: 
      <asp:Label ID="lblVisits" runat="server" CssClass="badge bg-secondary" />
    </div>

    <!-- ======= Try‑It section for Calendar Feed ======= -->
    <h3>Generate iCal feed from application cache</h3>

    <asp:Button 
      ID="btnShowCal" 
      runat="server" 
      CssClass="btn btn-success me-2"
      Text="Show Calendar Text"
      OnClick="btnShowCal_Click" />

    <a class="btn btn-success"
       href="api/calendar"
       target="_blank">
      Download .ics
    </a>

    <br /><br />

    <asp:TextBox 
      ID="txtCal"
      runat="server"
      TextMode="MultiLine"
      Rows="12"
      Width="100%"
      CssClass="form-control" />

    <hr />

    <!-- ======= Application & Components Summary ======= -->
    <h2>Application &amp; Components Summary</h2>
    <table class="table table-bordered table-sm">
      <thead class="table-light">
        <tr>
          <th>Provider</th>
          <th>Type</th>
          <th>Operation / Component</th>
          <th>Params</th>
          <th>Return</th>
          <th>Description</th>
          <th>Try‑It</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>Your Name</td>
          <td>DLL + Web API</td>
          <td>GenerateICal</td>
          <td>List&lt;EventDto&gt;</td>
          <td>.ics (string)</td>
          <td>Builds iCal feed from <code>Application["Events"]</code></td>
          <td><a href="api/calendar" target="_blank">Run</a></td>
        </tr>
      </tbody>
    </table>

  </main>

</asp:Content>
