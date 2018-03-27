<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MP_Admin.master" AutoEventWireup="true" CodeFile="GestionProductos.aspx.cs" Inherits="NavPrivada_GestProd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h1 class=" uk-heading-primary uk-text-center">Gestion de Productos</h1>
    <div class="uk-section-small uk-align-center">
        <div class="uk-container">
            <div class="uk-card uk-card-secondary">
                <div class="uk-card-body" uk-grid>
                    <h1 class="uk-card-title uk-width-1-1">Agregar Productos</h1>
                    <div class="uk-width-1-2@m">
                        <p>Descripcion Producto</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: tag"></span>
                            <asp:TextBox ID="txt_Descripcion" CssClass="uk-input uk-form-width-large" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="uk-width-1-2@m">
                        <p>Precio</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: credit-card"></span>
                            <asp:TextBox ID="txt_Precio" CssClass="uk-input uk-form-width-large" runat="server"></asp:TextBox>
                        </div>
                        <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer"
                            ControlToValidate="txt_Precio" ErrorMessage="Solamente se deben usar numeros" />
                    </div>
                    <div class="uk-width-1-2@m">
                        <p>Estado</p>
                        <div class="uk-inline">
                            <asp:DropDownList ID="dd_estadoN" CssClass="uk-select uk-form-width-medium" runat="server" ForeColor="#999999"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="uk-width-1-2@m">
                        <p>Tipo</p>
                        <div class="uk-inline">
                            <asp:DropDownList ID="dd_tipoN" CssClass="uk-select uk-form-width-medium" runat="server" ForeColor="#999999"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="uk-width-1-1">
                        <div class="uk-inline uk-position-bottom-center uk-position-relative">
                            <span class="uk-form-icon" uk-icon="icon: plus"></span>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Button ID="btn_crear" CssClass="uk-button uk-button-secondary uk-button-large uk-width-1-1" runat="server" Text="Crear Producto" OnClick="btn_crear_Click" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
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
                                <asp:TextBox ID="txt_codbarra" CssClass="uk-input" runat="server" Text='<%# Eval("CodBarra") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:Label ID="lbl_descripcion" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_descripcion" CssClass="uk-input" runat="server" Text='<%# Eval("Descripcion") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <ItemTemplate>
                                <asp:Label ID="lbl_precio" runat="server" Text='<%# Eval("Precio") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_precio" CssClass="uk-input" runat="server" Text='<%# Eval("Precio") %>'></asp:TextBox>
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
                        <asp:CommandField ButtonType="Link" ShowEditButton="true" EditText="<span uk-icon='icon: file-edit'></span>"
                            CancelText="<span uk-icon='icon: close'></span>" UpdateText="<span uk-icon='icon: check'></span>"
                            ShowDeleteButton="true" DeleteText="<span uk-icon='icon: trash'></span>" />
                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>

