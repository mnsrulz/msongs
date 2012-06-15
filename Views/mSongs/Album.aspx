<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/mSongs.Master" Inherits="System.Web.Mvc.ViewPage(Of mnsrulz.mnsrulz.mSongsModels.AlbumModel)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Album
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Album</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">ID</div>
        <div class="display-field"><%: Model.ID %></div>
        
        <div class="display-label">Title</div>
        <div class="display-field"><%: Model.Title %></div>
        
        <div class="display-label">Year</div>
        <div class="display-field"><%: Model.Year %></div>
        
        <h2>Songs</h2>

        <%
            For Each song In Model.Songs%>
                <span><%= song.Title%></span>
            <% Next%>
            

    </fieldset>
    <p>
        <%--<%: Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey})%> |--%>
        <%: Html.ActionLink("Back to List", "Albums") %>
    </p>

</asp:Content>

