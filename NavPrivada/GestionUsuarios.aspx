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
                            <asp:DropDownList ID="dd_estadoN" CssClass="uk-select uk-form-width-medium" runat="server" ForeColor="#999999"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="uk-width-1-4@m">
                        <p>Tipo</p>
                        <div class="uk-inline">
                            <asp:DropDownList ID="dd_tipoN"  CssClass="uk-select uk-form-width-medium" runat="server" ForeColor="#999999"></asp:DropDownList>
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
                    <div class="uk-width-1-1">
                        <div class="uk-inline uk-position-bottom-center uk-position-relative">
                            <span class="uk-form-icon" uk-icon="icon: lock"></span>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Button ID="btn_crear" CssClass="uk-button uk-button-secondary uk-button-large uk-width-1-1" runat="server" Text="Crear Usuario" OnClick="btn_crear_Click" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="uk-align-center">
        <div class="uk-container">
            <div class="uk-card uk-card-body uk-card-default uk-overflow-auto">
                <asp:GridView ID="GrillaUsuarios" CssClass="uk-table uk-table-divider uk-table-small" runat="server" AutoGenerateColumns="False" 
                    BorderStyle="None" GridLines="None" OnRowCancelingEdit="GrillaUsuarios_RowCancelingEdit" OnRowDataBound="GrillaUsuarios_RowDataBound" 
                    OnRowDeleting="GrillaUsuarios_RowDeleting" OnRowEditing="GrillaUsuarios_RowEditing" OnRowUpdating="GrillaUsuarios_RowUpdating" DataKeyNames="IdUsuario">
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre">
                            <ItemTemplate>
                                <asp:Label ID="lbl_nombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_nombre" CssClass="uk-input" runat="server" Text='<%# Eval("Nombre") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Apellido">
                            <ItemTemplate>
                                <asp:Label ID="lbl_apellido" runat="server" Text='<%# Eval("Apellido") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_apellido" CssClass="uk-input" runat="server" Text='<%# Eval("Apellido") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Correo">
                            <ItemTemplate>
                                <asp:Label ID="lbl_correo" runat="server" Text='<%# Eval("Correo") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_correo" CssClass="uk-input" runat="server" Text='<%# Eval("Correo") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contraseña">
                            <ItemTemplate>
                                <asp:Label ID="lbl_password" runat="server" Text=*****></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_password" CssClass="uk-input" runat="server" Text='<%# Eval("Password") %>' TextMode="Password"></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Estado" runat="server" Text='<%# Eval("DescEstado") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="dd_estado" CssClass="uk-select" runat="server"></asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tipo">
                            <ItemTemplate>
                                <asp:Label ID="lbl_Tipo" runat="server" Text='<%# Eval("DescTipo") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="dd_tipo" CssClass="uk-select" runat="server"></asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Link" ShowEditButton="true"  EditText="<span uk-icon='icon: file-edit'></span>"
                            CancelText="<span uk-icon='icon: close'></span>" UpdateText="<span uk-icon='icon: check'></span>"
                            ShowDeleteButton="true" DeleteText="<span uk-icon='icon: trash'></span>" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
