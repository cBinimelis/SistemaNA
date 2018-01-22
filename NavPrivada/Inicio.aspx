<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MP_Admin.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="NavAdmin_Inicio" EnableEventValidation="False" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="uk-section uk-align-center">
        <div class="uk-container">
            <div class="uk-card uk-card-body uk-card-secondary">
                <div class="uk-card-header uk-align-center">
                    <h1 class="uk-card-title uk-align-center">Generador de Codigo de Barra</h1>
                </div>
                <div uk-grid>
                    <div class="uk-width-1-2@m uk-overflow-auto">

                        <asp:GridView ID="GridView1" CssClass="uk-table uk-table-small" runat="server" AutoGenerateColumns="False" DataKeyNames="IdProducto" DataSourceID="ConBDNAnahi" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound">
                            <Columns>
                                <asp:BoundField DataField="IdProducto" HeaderText="IdProducto" InsertVisible="False" ReadOnly="True" SortExpression="IdProducto" Visible="False" />
                                <asp:BoundField DataField="CodBarra" HeaderText="Codigo de Barras" SortExpression="CodBarra" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion de Producto" SortExpression="Descripcion" />
                                <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" Visible="False" />
                                <asp:BoundField DataField="Unidades" HeaderText="Unidades" SortExpression="Unidades" Visible="False" />
                                <asp:BoundField DataField="FechaCreacion" HeaderText="FechaCreacion" SortExpression="FechaCreacion" Visible="False" />
                                <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" SortExpression="IdUsuario" Visible="False" />
                                <asp:BoundField DataField="IdTienda" HeaderText="IdTienda" SortExpression="IdTienda" Visible="False" />
                            </Columns>
                        </asp:GridView>
                        <asp:LinkButton ID="lnkDummy" runat="server"></asp:LinkButton>
                        <asp:SqlDataSource ID="ConBDNAnahi" runat="server" ConnectionString="<%$ ConnectionStrings:bd_nanahiConS %>" SelectCommand="SELECT * FROM [Productos]"></asp:SqlDataSource>
                    </div>
                    <div class="uk-width-1-2@m">
                        <div class="uk-card uk-card-default">
                            <asp:Image ID="Image1" CssClass="uk-align-center uk-margin" runat="server" Height="100px" Width="200" />
                        </div>
                        <div class="uk-inline uk-width-1-1">
                            <span class="uk-form-icon" uk-icon="icon: user"></span>
                            <asp:TextBox ID="txt_codigo" CssClass="uk-input" runat="server"></asp:TextBox>
                        </div>
                        <asp:Button ID="btn_generar" CssClass="uk-button uk-button-secondary uk-width-1-1" runat="server" OnClick="btn_generar_Click" Text="Generar Codigo" />

                </div>


            </div>
        </div>
    </div>

</asp:Content>

