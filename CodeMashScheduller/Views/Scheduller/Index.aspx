<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CodeMashScheduller.Models.SchedulleModel>" %>

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
</script>
</asp:Content>


