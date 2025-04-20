<%@ Page Title="Home Page"
         Language="C#"
         MasterPageFile="~/Site.Master"
         AutoEventWireup="true"
         CodeBehind="Default.aspx.cs"
         Inherits="App_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main class="container">

        <!-- ***** Existing template content (you can keep or trim) ***** -->
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">
                ASP.NET is a free web framework for building great Web sites and Web applications
                using HTML, CSS, and JavaScript.
            </p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>
        <!-- ************************************************************ -->

        <hr />

        <!-- ========== Try‑It section for Calendar Feed ================= -->
       <h3>Generate iCal feed from application cache</h3>

<asp:Button ID="btnShowCal"
            runat="server"
            CssClass="btn btn-success"
            Text="Show Calendar Text"
            OnClick="btnShowCal_Click" />

<!-- Download link -->
<a class="btn btn-success"
   href="https://localhost:44322/api/calendar">Download .ics</a>

<br /><br />

<asp:TextBox ID="txtCal"
             runat="server"
             TextMode="MultiLine"
             Rows="12"
             Width="100%"
             CssClass="form-control" />

        <!-- ============================================================ -->

        <h3>Application &amp; Components Summary</h3>

<table class="table table-bordered table-sm">
    <thead>
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
            <td>DLL + Web API</td>
            <td>GenerateICal</td>
            <td>List&lt;EventDto&gt;</td>
            <td>.ics (string)</td>
            <td>Build iCal feed from Events cache</td>
            <td><a href="https://webstrarX.fulton.asu.edu/page1/api/calendar"
                   target="_blank">Run</a></td>
        </tr>
        <!-- add more rows as you add components -->
    </tbody>
</table>


    </main>

</asp:Content>
