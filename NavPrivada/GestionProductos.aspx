<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MP_Admin.master" AutoEventWireup="true" CodeFile="GestionProductos.aspx.cs" Inherits="NavPrivada_GestProd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h1 class=" uk-heading-primary uk-text-center">Gestion de Productos</h1>
    <div class="uk-section-small uk-align-center">
        <div class="uk-container">
            <div class="uk-card uk-card-secondary">
                <div class="uk-card-body" uk-grid>
                    <h1 class="uk-card-title">Agregar Productos</h1>
                    <div>

                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="uk-container">
        <div class="uk-card uk-card-default">
            <div class="uk-card-body">
                <asp:GridView ID="GrillaProductos" CssClass="uk-table uk-table-divider uk-table-small" DataKeyNames="IdProducto" AutoGenerateColumns="false"
                    runat="server" GridLines="None" OnRowCancelingEdit="GrillaProductos_RowCancelingEdit" OnRowDataBound="GrillaProductos_RowDataBound" OnRowDeleting="GrillaProductos_RowDeleting" OnRowEditing="GrillaProductos_RowEditing" OnRowUpdating="GrillaProductos_RowUpdating">
                    <Columns>
                        <asp:TemplateField HeaderText="Codigo de Barras">
                            <ItemTemplate>
                                <asp:Label ID="lbl_codbarra" runat="server" Text='<%# Eval("CodBarra") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_codbarra" CssClass="uk-input" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:Label ID="lbl_descripcion" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_descripcion" CssClass="uk-input" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <ItemTemplate>
                                <asp:Label ID="lbl_precio" runat="server" Text='<%# Eval("Precio") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_precio" CssClass="uk-input" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha de Creacion">
                            <ItemTemplate>
                                <asp:Label ID="lbl_fecha" runat="server" Text='<%# Eval("Fecha_Creacion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Creador">
                            <ItemTemplate>
                                <asp:Label ID="lbl_idusuario" runat="server" Text='<%# Eval("Usuario") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                
            </div>
        </div>
    </div>
</asp:Content>

