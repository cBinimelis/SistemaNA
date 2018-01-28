<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MP_Admin.master" AutoEventWireup="true" CodeFile="GestionUsuarios.aspx.cs" Inherits="NavPrivada_GestionUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="uk-section uk-align-center">
        <div class="uk-container">
            <div class="uk-card uk-card-secondary">
                <div class="uk-card-body" uk-grid>
                    <h1 class="uk-card-title uk-width-1-1">Gestion de Usuarios</h1>
                    <div class="uk-width-1-2@m">
                        <p>Nombre</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: user"></span>
                            <asp:TextBox ID="txt_NombreN" CssClass="uk-input uk-form-width-large" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="uk-width-1-2@m">
                        <p>Apellido</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: users"></span>
                            <asp:TextBox ID="txt_ApellidoN" CssClass="uk-input uk-form-width-large" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="uk-width-1-2@m">
                        <p>Correo</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: mail"></span>
                            <asp:TextBox ID="txt_CorreoN" CssClass="uk-input uk-form-width-large" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="uk-width-1-4@m">
                        <p>Estado</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: users"></span>
                            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="uk-width-1-4@m">
                        <p>Tipo</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: user"></span>
                            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="uk-width-1-2@m">
                        <p>Contraseña</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: lock"></span>
                            <asp:TextBox ID="txt_PasswordN" CssClass="uk-input uk-form-width-large" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="uk-width-1-2@m">
                        <p>Repetir Contraseña</p>
                        <div class="uk-inline">
                            <span class="uk-form-icon" uk-icon="icon: lock"></span>
                            <asp:TextBox ID="txt_ConfPass" CssClass="uk-input uk-form-width-large" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="uk-align-center">
        <div class="uk-container">
            <div class="uk-card uk-card-body uk-card-default">
                <asp:GridView ID="GrillaUsuarios" CssClass="uk-table uk-table-divider uk-table-small" runat="server" AutoGenerateColumns="False" BorderStyle="None" GridLines="None" OnRowCancelingEdit="GrillaUsuarios_RowCancelingEdit" OnRowDataBound="GrillaUsuarios_RowDataBound" OnRowDeleting="GrillaUsuarios_RowDeleting" OnRowEditing="GrillaUsuarios_RowEditing" OnRowUpdating="GrillaUsuarios_RowUpdating">
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Nombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_Nombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Apellido">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Apellido" runat="server" Text='<%# Eval("Apellido") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_Apellido" runat="server" Text='<%# Eval("Apellido") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Correo">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Correo" runat="server" Text='<%# Eval("Correo") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_Correo" runat="server" Text='<%# Eval("Correo") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contraseña">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Password" runat="server" Text='<%# Eval("Password") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_Password" runat="server" Text='<%# Eval("Password") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Estado" runat="server" Text='<%# Eval("IdEstadoUsuario") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_Estado" runat="server" Text='<%# Eval("IdEstadoUsuario") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tipo">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Tipo" runat="server" Text='<%# Eval("IdTipoUsuario") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_Tipo" runat="server" Text='<%# Eval("IdTipoUsuario") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Link" ShowEditButton="true" ControlStyle-CssClass=" uk-icon" EditText="<a uk-icon='icon: file-edit'></a>"
                            CancelText="<a uk-icon='icon: close'></a>" UpdateText="<a uk-icon='icon: check'></a>"
                            ShowDeleteButton="true" DeleteText="<a uk-icon='icon: trash'></a>" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>

