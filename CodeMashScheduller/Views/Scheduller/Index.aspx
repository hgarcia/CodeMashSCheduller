<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<CodeMashScheduller.Models.Session>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
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
                    <td class="left"><strong>Sessions</strong> 
                        <ul id="sessions-day1" class="dropable connectedSortable-day1">
                        <%
                            //TODO: Fix this once we have dates in the sessions.
                        foreach (var session in Model.Where(s=>s.Start.GetValueOrDefault(DateTime.Now) <= new DateTime(2010,1,13)))
                        {
                          Html.RenderPartial("_sessionDetails", session);
                        }
                        %>
                        </ul></td>
                    <td><strong>My sessions</strong> 
                        <ul id="mySessions-day1" class="dropable connectedSortable-day1">

                        </ul></td>
                </tr>
            </tbody>
        </table>
    </div>
    <div id="tabs-2">
        <table class="ui-widget-content ui-corner-all">
            <tbody>
                <tr>
                    <td class="left"><strong>Sessions</strong> 
                        <ul id="sessions-day2" class="dropable connectedSortable-day2">
                        <%
                            foreach (var session in Model.Where(s => s.Start.GetValueOrDefault(DateTime.Now) >= new DateTime(2010, 1, 14)))
                        {
                          Html.RenderPartial("_sessionDetails", session);
                        }
                        %>
                        </ul></td>
                    <td><strong>My sessions</strong> 
                        <ul id="mySessions-day2" class="dropable connectedSortable-day2">

                        </ul></td>
                </tr>
            </tbody>
        </table>
    </div>
    <div id="tabs-3">
        <table class="ui-widget-content ui-corner-all">
            <tbody>
                <tr>
                    <td class="left"><strong>Sessions</strong> 
                        <ul id="sessions-day3" class="dropable connectedSortable-day3">
                        <%
                            foreach (var session in Model.Where(s => s.Start.GetValueOrDefault(DateTime.Now) >= new DateTime(2010, 1, 15)))
                        {
                          Html.RenderPartial("_sessionDetails", session);
                        }
                        %>
                        </ul></td>
                    <td><strong>My sessions</strong> 
                        <ul id="mySessions-day3" class="dropable connectedSortable-day3">

                        </ul></td>
                </tr>
            </tbody>
        </table>
    </div>        
</div>

<script type="text/javascript">
    $(function() {
        $("#sessions-day1, #mySessions-day1").sortable({
            connectWith: '.connectedSortable-day1',
            placeholder: 'ui-state-highlight'
        }).disableSelection();
            
            $("#sessions-day2, #mySessions-day2").sortable({
            connectWith: '.connectedSortable-day2',
                placeholder: 'ui-state-highlight'
            }).disableSelection();
            
            $("#sessions-day3, #mySessions-day3").sortable({
                connectWith: '.connectedSortable-day3',
                placeholder: 'ui-state-highlight'
            }).disableSelection();
    });
	$(function() {
		$("#tabs").tabs();
	});
</script>
</asp:Content>


