<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MP_Admin.master" AutoEventWireup="true" CodeFile="VerCarrito.aspx.cs" Inherits="NavPrivada_VerCarrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="uk-section">
        <div class="uk-container">
            <h1>
            Carrito de Compras</h1>
        <a href="CatalogoProductos.aspx">Seguir Comprando</a>
        <br />
        <br />

        <asp:GridView ID="gvCaritoCompras" AutoGenerateColumns="false" EmptyDataText="No hay nada en su carrito de compras."
            GridLines="None" Width="100%" CellPadding="5" ShowFooter="true" DataKeyNames="IdProducto"
            OnRowCommand="gvCaritoCompras_RowCommand" OnRowDataBound="gvCaritoCompras_RowDataBound" runat="server" >
            <HeaderStyle HorizontalAlign="Left" BackColor="BlueViolet" ForeColor="AliceBlue" />
            <FooterStyle HorizontalAlign="Right" BackColor="Chocolate" ForeColor="Aqua" />
            <AlternatingRowStyle BackColor="Azure" />
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:TemplateField HeaderText="Cantidad">
                    <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtCantidad" Columns="5" Text='<%# Eval("Cantidad") %>'></asp:TextBox><br />
                        <asp:LinkButton runat="server" ID="btnEliminar" Text="Eliminar" CommandName="Eliminar"
                            CommandArgument='<%# Eval("IdProducto") %>' Style="font-size: 12px;"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="PrecioUnitario" HeaderText="Precio" ItemStyle-HorizontalAlign="Right"
                    HeaderStyle-HorizontalAlign="Right" DataFormatString="{0:C}" />
                <asp:BoundField DataField="Total" HeaderText="Total" ItemStyle-HorizontalAlign="Right"
                    HeaderStyle-HorizontalAlign="Right" DataFormatString="{0:C}" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button runat="server" ID="btActulizar" Text="Actualizar el Carrito"
            onclick="btActulizar_Click"/>
        </div>
    </div>
</asp:Content>

