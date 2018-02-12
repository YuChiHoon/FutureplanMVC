<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommunityView.aspx.cs" Inherits="MemoEngine.Admin.Community.CommunityView" %>

<%@ Register Src="~/Controls/Community/CommunityViewUserControl.ascx" TagPrefix="uc1" TagName="CommunityViewUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:CommunityViewUserControl runat="server" ID="CommunityViewUserControl" />
        </div>
    </form>
</body>
</html>
