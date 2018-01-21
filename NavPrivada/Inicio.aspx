<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MP_Admin.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="NavAdmin_Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">.
    <div> <br />
   Barcodes generation
   <br /><br /><br />
        <asp:Panel ID="Panel1" runat="server" DefaultButton="Button1" Height="50px" Width="325px">
           <asp:TextBox ID="TextBox1" Text="type here" runat="server"></asp:TextBox><br />
           <asp:Button ID="Button1" runat="server" OnClick="btn_generar_Click" Text="Code 128" />

        </asp:Panel>
        <br />
        <asp:Image ID="Image1" runat="server" />&nbsp;</div>
</asp:Content>

