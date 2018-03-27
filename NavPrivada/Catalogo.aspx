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

                <asp:GridView ID="grillaProductos" CssClass="uk-table uk-table-divider uk-table-small" DataKeyNames="IdProducto" AutoGenerateColumns="false"
                    GridLines="None" runat="server" OnRowCommand="grillaProductos_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="ID Producto">
                            <ItemTemplate>
                                <asp:Label ID="lbl_id" runat="server" Text='<%# Eval("IdProducto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Codigo de Barras">
                            <ItemTemplate>
                                <asp:Label ID="lbl_codbarra" runat="server" Text='<%# Eval("CodBarra") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:Label ID="lbl_descripcion" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <ItemTemplate>
                                <asp:Label ID="lbl_precio" runat="server" Text='<%# Eval("Precio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="Agregar" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Button ID="btn_verCarrito" CssClass="uk-button uk-button-secondary uk-width-1-1" runat="server" OnClick="btn_verCarrito_Click" Text="Ver Carro" />

            </div>
        </div>
    </div>
</asp:Content>

