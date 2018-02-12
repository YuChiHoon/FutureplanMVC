<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommunityWriteUserControl.ascx.cs" Inherits="MemoEngine.Controls.Community.CommunityWriteUserControl" %>
<h1>커뮤니티 정보 입력</h1>

<div class="form-group">
    <label for="txtCommunityName" class="col-sm-2 control-label">커뮤니티 이름: </label>
    <div class="col-sm-10">
        <input type="text" class="form-control" id="txtCommunityName" runat="server" placeholder="커뮤니티 이름" />
    </div>
</div>

<div class="form-group">
    <label for="txtCommunityDescription" class="col-sm-2 control-label">커뮤니티 설명: </label>
    <div class="col-sm-10">
        <input type="text" class="form-control" id="txtCommunityDescription" runat="server" placeholder="커뮤니티 설명" />
    </div>
</div>

<div class="form-group">
    <label for="txtMeaderHtnl" class="col-sm-2 control-label">헤더 영역 HTML: </label>
    <div class="col-sm-10">
        <input type="text" class="form-control" id="txtMeaderHtnl" runat="server" placeholder="헤더 영역 HTML" />
    </div>
</div>

<div class="form-group">
    <label for="txtFooterHtnl" class="col-sm-2 control-label">푸터 영역 HTML: </label>
    <div class="col-sm-10">
        <input type="text" class="form-control" id="txtFooterHtnl" runat="server" placeholder="푸터 영역 HTML" />
    </div>
</div>

<asp:Button ID="btnAdd" runat="server" Text="저장" OnClick="btnAdd_Click" CssClass="btn btn-primary btn-lg" ValidationGroup="FrmCommunity"/>

<asp:HyperLink ID="lnkList" runat="server" NavigateUrl="~/Admin/Community/CommnuityList.aspx">리스트</asp:HyperLink>

<br />
<asp:Label ID="lblDisplay" runat="server" Text=""></asp:Label>


<div>

    <asp:RequiredFieldValidator ID="valCommunityName" runat="server" ControlToValidate="txtCommunityName"
        ErrorMessage="CommunityName을 입력하시오." Display="None" ValidationGroup="FrmCommunity" SetFocusOnError="true"></asp:RequiredFieldValidator>

    <asp:ValidationSummary ID="valSummary" runat="server" ShowMessageBox ="true" ShowSummary="false" ValidationGroup="FrmCommunity"/>

</div>