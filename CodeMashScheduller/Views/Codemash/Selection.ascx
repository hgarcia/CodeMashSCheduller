<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CodeMashScheduller.Models.SavedSessions>" %>

Hello from the selected sessions.

<%=Model.Name %><br />
<%=Model.Precompilers %><br />
<%=Model.Sessions %><br />

