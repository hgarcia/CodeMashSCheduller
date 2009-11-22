<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CodeMashScheduller.Models.Session>" %>
<li class="item ui-corner-all">
    <div class="ui-widget-content ui-corner-all">
    <h3 class="ui-widget-header ui-corner-all"><%= Model.Title.Encode() %></h3>
        <p>
            Speaker: <%= Model.SpeakerName.Encode() %><br />
            Level: <%=Model.Difficulty.ToString().Encode() %><br/>
            <a id="<%= Model.URI %>" class="clickable" onclick="$('#Abstract-for-<%= Model.URI%>').toggle('fold',{},500);">Details >>></a>
            <div id="Abstract-for-<%= Model.URI%>" class="hidden ui-corner-all"><%=Model.Abstract.Encode() %></div>
        </p> 
    </div>
</li>

