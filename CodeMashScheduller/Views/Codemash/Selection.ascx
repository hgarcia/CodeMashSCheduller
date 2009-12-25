<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CodeMashScheduller.Models.SchedulleModel>" %>

<table>
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

