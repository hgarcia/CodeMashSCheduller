<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CodeMashScheduller.Models.ISession>" %>
<div class="item ui-widget-content ui-corner-all">
<h3 class="ui-widget-header ui-corner-all"><%= Model.Title.Encode() %></h3>
    <p>
        Speaker: <%= Model.SpeakerName.Encode() %><br />
        Level: <%=Model.Difficulty.ToString().Encode() %><br/>
        Start: <%=Model.Start.ToString() %><br />
        Room: <%=Model.Room %><br />
        Details: <br /><%=Model.Abstract.Encode() %>
    </p> 
</div>

