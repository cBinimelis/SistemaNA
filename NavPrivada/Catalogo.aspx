<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MP_Admin.master" AutoEventWireup="true" CodeFile="Catalogo.aspx.cs" Inherits="NavPrivada_Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="uk-section">
        <div class="uk-container">
            <div class="uk-card uk-card-large uk-card-body uk-card-secondary">
                <div class="uk-card-header uk-align-center">
                    <h1 class="uk-card-title uk-align-center">Catalogo de Productos</h1>
                </div>

                <asp:GridView ID="grillaProductos"  CssClass="uk-table uk-table-divider uk-table-small" DataKeyNames="IdProducto" AutoGenerateColumns="false"
                    GridLines="None" runat="server">

                </asp:GridView>

            </div>


            <table style="width: 600px; border: 1px;">
                <thead>
                    <tr style="border: 1px;">
                        <th colspan="2" style="font-size: x-large; font-weight: bold; text-align: center; text-transform: uppercase; background-color: #999999; color: #FFFFFF;">Tienda al mayoreo
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr style="border: 1px;">
                        <td class="style2" style="font-size: larger; font-weight: bold; text-align: left; text-transform: capitalize;">Zapatos Deportivos
                        </td>
                        <td class="style3">
                            <asp:LinkButton ID="lbZapatos" runat="server" OnClick="lbZapatos_Click">Agregar al Carrito</asp:LinkButton>
                        </td>
                    </tr>
                    <tr style="border: 1px;">
                        <td class="style2" style="font-size: larger; font-weight: bold; text-align: left; text-transform: capitalize;">Camisas Deportivas
                        </td>
                        <td class="style3">
                            <asp:LinkButton ID="lbCamisas" runat="server" OnClick="lbCamisas_Click">Agregar al Carrito</asp:LinkButton>
                        </td>
                    </tr>
                    <tr style="border: 1px;">
                        <td class="style2" style="font-size: larger; font-weight: bold; text-align: left; text-transform: capitalize;">Pantalones Cortos
                        </td>
                        <td class="style3">
                            <asp:LinkButton ID="lbPantalones" runat="server" OnClick="lbPantalones_Click">Agregar al Carrito</asp:LinkButton>
                        </td>
                    </tr>
                    <tr style="border: 1px;">
                        <td class="style2" style="font-size: larger; font-weight: bold; text-align: left; text-transform: capitalize;">Sandalias
                        </td>
                        <td class="style3">
                            <asp:LinkButton ID="lbSandalias" runat="server" OnClick="lbSandalias_Click">Agregar al Carrito</asp:LinkButton>
                        </td>
                    </tr>
                    <tr style="border: 1px;">
                        <td class="style2" style="font-size: larger; font-weight: bold; text-align: left; text-transform: capitalize;">Boxer
                        </td>
                        <td class="style3">
                            <asp:LinkButton ID="lbBoxer" runat="server" OnClick="lbBoxer_Click">Agregar al Carrito</asp:LinkButton>
                        </td>
                    </tr>
                    <tr style="border: 1px;">
                        <td class="style1" colspan="2"></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

