<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommunityWrite.aspx.cs" Inherits="MemoEngine.Admin.Community.CommunityWrite" %>

<%@ Register Src="~/Controls/Community/CommunityWriteUserControl.ascx" TagPrefix="uc1" TagName="CommunityWriteUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:CommunityWriteUserControl runat="server" ID="CommunityWriteUserControl" />
        </div>
    </form>
</body>
</html>
