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

        <asp:Button runat="server"
                    ID="btnShowCal"
                    CssClass="btn btn-success"
                    Text="Show Calendar Text"
                    OnClick="btnShowCal_Click" />

        <br /><br />

        <asp:TextBox runat="server"
                     ID="txtCal"
                     TextMode="MultiLine"
                     Rows="12"
                     Width="100%"
                     CssClass="form-control" />
        <!-- ============================================================ -->

    </main>

</asp:Content>
