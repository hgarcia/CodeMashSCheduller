<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CodeMashScheduller.Models.SchedulleModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Codemash sessions I plan to attend.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="ui-corner-all ui-widget-header">
    <button id="exportICal" class="ui-button ui-state-default ui-corner-all">Export as iCal</button>&nbsp;&nbsp;
    <!-- AddThis Button BEGIN -->
    <a class="addthis_button" href="http://addthis.com/bookmark.php?v=250&amp;username=xa-4b3043480f0eeb87">
    <img src="http://s7.addthis.com/static/btn/v2/lg-share-en.gif" width="125" height="16" alt="Bookmark and Share" style="border:0"/></a>
    <script type="text/javascript" src="http://s7.addthis.com/js/250/addthis_widget.js#username=xa-4b3043480f0eeb87"></script>
    <!-- AddThis Button END -->
</div>
<table id="selectedSessions">
<tr>
    <th>Precompiler</th>
    <th>Day 1</th>
    <th>Day 2</th>
</tr>
<tr>
    <td>
        <%
            foreach (var precompiler in Model.Precompiler)
            {
                Html.RenderPartial("_sessionDetails", precompiler);
            }
         %>
    </td>
    <td>
        <%
            foreach (var session in Model.Day1)
            {
                Html.RenderPartial("_sessionDetails", session);
            }
         %>    
    </td>
    <td>
    
        <%
            foreach (var session in Model.Day2)
            {
                Html.RenderPartial("_sessionDetails", session);
            }
         %>    
    </td>
</tr>
</table>
<script type="text/javascript" src="../../Scripts/codemash.js"></script>
<script type="text/javascript">
    var link = '<%=Url.Action("Calendar",new{Id=ViewData["name"]}) %>';
    $('#exportICal').bind('click', function(e) {
        window.open(link);
    });
</script>
</asp:Content>
