<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CodeMashScheduller.Models.SchedulleModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Codemash schedule - select the sessions you want to see.
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="ui-corner-all ui-widget-header">
    <button id="saveSessions" class="ui-button ui-state-default ui-corner-all">save schedule</button>&nbsp;&nbsp;
    <!-- AddThis Button BEGIN -->
    <a class="addthis_button" href="http://addthis.com/bookmark.php?v=250&amp;username=xa-4b3043480f0eeb87">
    <img src="http://s7.addthis.com/static/btn/v2/lg-share-en.gif" width="125" height="16" alt="Bookmark and Share" style="border:0"/></a>
    <script type="text/javascript" src="http://s7.addthis.com/js/250/addthis_widget.js#username=xa-4b3043480f0eeb87"></script>
    <!-- AddThis Button END -->
</div>
<form id="sessionList">
<div id="tabs">
	<ul>
		<li><a href="#tabs-1">Precompiler - Jan 13th</a></li>
		<li><a href="#tabs-2">Day 1 - Jan 14th</a></li>
		<li><a href="#tabs-3">Day 2 - Jan 15th</a></li>
	</ul>
    <div id="tabs-1">
        <table class="ui-widget-content ui-corner-all">
            <tbody>
                <tr>
                <td>
                <%
                foreach (var session in Model.Precompiler.Where(p=>p.Room == "Indigo Bay"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>               
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "Cypress"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %> 
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "E"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "D"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "Mangrove"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "Portia/Wisteria"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "Guava/Tamarin"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "C"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Precompiler.Where(p => p.Room == "F"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>                
                </tr>
            </tbody>
        </table>
    </div>
     <div id="tabs-2">
        <table class="ui-widget-content ui-corner-all">
            <tbody>
                <tr>
                <td>
                <%
                foreach (var session in Model.Day1.Where(p=>p.Room == "Indigo Bay"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>               
                </td>
                <td>
                <%
                    foreach (var session in Model.Day1.Where(p => p.Room == "Cypress"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %> 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day1.Where(p => p.Room == "E"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day1.Where(p => p.Room == "D"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day1.Where(p => p.Room == "Mangrove"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day1.Where(p => p.Room == "Portia/Wisteria"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>             
                </tr>
            </tbody>
        </table>
    </div>    
     <div id="tabs-3">
        <table class="ui-widget-content ui-corner-all">
            <tbody>
                <tr>
                <td>
                <%
                    foreach (var session in Model.Day2.Where(p => p.Room == "Indigo Bay"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>               
                </td>
                <td>
                <%
                    foreach (var session in Model.Day2.Where(p => p.Room == "Cypress"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %> 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day2.Where(p => p.Room == "E"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day2.Where(p => p.Room == "D"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day2.Where(p => p.Room == "Mangrove"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>
                <td>
                <%
                    foreach (var session in Model.Day2.Where(p => p.Room == "Portia/Wisteria"))
                {
                  Html.RenderPartial("_sessionDetails", session);
                }
                %>                 
                </td>     
                </tr>
            </tbody>
        </table>
    </div>    
</div>
</form>
<div id="no-sessions">No sessions selected. Nothing will be saved.</div>
<div id="saved-sessions"></div>
<script type="text/javascript">
    $('a.clickable').each(function() {
        $(this).qtip({
        content: $(this).attr('tooltip'), // Use the tooltip attribute of the element for the content
            style: { name: 'dark', border: { radius: 5 }, width: { max: 500 }  },
            show: { when: 'click', solo: true }, // Give it a crea mstyle to make it stand out
            hide: { when: 'mouseout', fixed: true },
            position: { adjust: { screen: true} }
        });
    });
	$(function() {
		$("#tabs").tabs();
});
$('#no-sessions').dialog({
    autoOpen: false,
    height: 100,
    modal: true,
    title: 'Oops, I can\'t proceed'
});
$('#saved-sessions').dialog({
    autoOpen: false,
    height: 100,
    modal: true,
    title: 'Sessions selected saved.'
});
$('#saveSessions').bind('click', function(e) {
    var sessions = $('#sessionList').serialize();
    if (sessions == "") {
        $('#no-sessions').dialog('open');
        return;
    }
    $.post("Scheduler/Save", sessions, function(data) {
        $('#saved-sessions').html('Visit your schedule <a href="codemash/selection/' + data + '" target="_blank">clicking here</a>.');
        $('#saved-sessions').dialog('open');
    }, "json"
        );
});
	
</script>
</asp:Content>


