<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pageDANHSACHSACH.aspx.cs" Inherits="IS385_NGUYENQUANGHAN_1605_QUANLYSACH.pageDANHSACHSACH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
         <div style="padding-left:0.25rem; text-align:center">
                 <a href ="pageCHITIETSACH.aspx?IDS=<%# Eval("MASACH") %>" style="text-decoration:none">
                <%# Eval("TENSACH") %>
                <br/>
                <img src='IMAGES\<%# Eval("HINH") %>' width="60%" height="90%" />
            </a>
            <br />
                Giá: <%# Eval("DONGIA") %>
         </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
