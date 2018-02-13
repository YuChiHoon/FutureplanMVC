<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommunityListUserControl.ascx.cs" Inherits="MemoEngine.Controls.Community.CommunityListUserControl" %>
<h1>커뮤니티 정보 출력</h1>

<asp:GridView ID="grdCommunityList" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered table-condensed table-hover">
    <Columns>
        <asp:BoundField HeaderText="번호" DataField="CommunityId" ItemStyle-Width="50px"/>
        <asp:HyperLinkField HeaderText="커뮤니티 이름" 
            DataTextField="CommunityName"
            DataNavigateUrlFormatString="~/Admin/Community/CommunityView.aspx?CommunityId={0}"
            DataNavigateUrlFields="CommunityId"/>
        <asp:TemplateField HeaderText="생성일">
            <ItemTemplate>
                <!-- %# FuncShowTime(Eval("CreationDate")) % -->
                <%# MemoEngine.Libraries.CommunityLibrary.FuncShowTime(Eval("CreationDate")) %>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>

</asp:GridView>
