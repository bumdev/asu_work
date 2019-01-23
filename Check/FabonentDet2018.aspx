<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FabonentDet2018.aspx.cs" Inherits="kipia_web_application.FabonentDet2018" %>

<%@ Register src="../Controls/FAbonDet2018.ascx" tagname="FAbonDet2018" tagprefix="uc1" %>

<!DOCTYPE html>
<link href="../Css/style.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <telerik:RadScriptManager runat="server" ID="RadScriptManager1" /> 
        
          <telerik:RadAjaxManager ID="RadAjaxManager" runat="server" DefaultLoadingPanelID="LoadingPanel1"></telerik:RadAjaxManager>
        
    </div>
        <uc1:FAbonDet2018 ID="FAbonDet20181" runat="server" />
    </form>
</body>
</html>
