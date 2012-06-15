<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/mSongs.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Albums
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%  
        Dim lst As mnsrulz.mnsrulz.mSongsModels.AlbumsModel = ViewData("list")
        For Each album In lst%>
        <%= Html.ActionLink(album.Title, "Album", New With {.albumId = album.ID})%>
        <br />
            <%--<span><%= album.Title%></span>--%>
        <%Next%>
</asp:Content>
