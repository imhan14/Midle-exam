<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pageCHITIETSACH.aspx.cs" Inherits="IS385_NGUYENQUANGHAN_1605_QUANLYSACH.pageCHITIETSACH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server" >
         <ItemTemplate>
             <table style="width: 100%; height:100%;">
                 <tr style="display:flex; justify-content:center; align-items:center; height:100%">
                     <td>
                         <img src='IMAGES\<%# Eval("HINH") %>' width="100" height="150" />
                     </td>
                     <td style="margin-left:1rem">Tên Sách: <%# Eval("TENSACH") %>
                         <br />
                        Nhà xuất bản: <%# Eval("NHAXB") %>
                         <br />
                        Mô tả: <%# Eval("MOTA") %>
                         <br />
                         <span style="color:red;">Giá: <%# Eval("DONGIA") %></span>
                        

                     </td>
                 </tr>
             </table>
            
            
            
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
