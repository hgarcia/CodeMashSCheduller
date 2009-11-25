<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Re cache data</h2>
    <%using(Html.BeginForm("ReCache","CacheData")){%>
    
      <input type="submit" value="ReCache Sessions" />  
      
    <%} %>
</asp:Content>
