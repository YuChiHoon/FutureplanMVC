<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommnuityList.aspx.cs" Inherits="MemoEngine.Admin.Community.CommnuityList" %>

<%@ Register Src="~/Controls/Community/CommunityListUserControl.ascx" TagPrefix="uc1" TagName="CommunityListUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:CommunityListUserControl runat="server" ID="CommunityListUserControl" />
        </div>
    </form>
</body>
</html>
