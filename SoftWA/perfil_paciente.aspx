﻿<%@ Page Language="C#" MasterPageFile="~/SoftMA_Paciente.Master" AutoEventWireup="true" CodeBehind="perfil_paciente.aspx.cs" Inherits="SoftWA.MA_Paciente.perfil_paciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="chpTitulo" runat="server">
    Perfil de Paciente
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="container mt-5 mb-5">
        <div class="row justify-content-center">
            <div class="col-md-8 col-lg-7">
                <asp:Panel ID="pnlMensaje" runat="server" Visible="false" CssClass="alert alert-dismissible fade show mb-3" role="alert">
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
                </asp:Panel>
                <asp:Panel ID="pnlViewProfile" runat="server" Visible="true">
                    <div class="card shadow-sm">
                        <div class="card-header d-flex justify-content-between align-items-center">
                            <h4 class="mb-0"><i class="fa-solid fa-user me-2"></i>Mi Perfil</h4>
                            <asp:Button ID="btnEdit" runat="server" Text="Editar Perfil" CssClass="btn btn-outline-primary btn-sm" OnClick="btnEdit_Click" />
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6 mb-3">
                                    <span class="profile-label">Nombres:</span><br />
                                    <asp:Label ID="lblNombresView" runat="server" CssClass="profile-value"></asp:Label>
                                </div>
                                <div class="col-md-6 mb-3">
                                    <span class="profile-label">Apellido Paterno:</span><br />
                                    <asp:Label ID="lblApellidoPaternoView" runat="server" CssClass="profile-value"></asp:Label>
                                </div>
                                    <div class="col-md-6 mb-3">
                                    <span class="profile-label">Apellido Materno:</span><br />
                                    <asp:Label ID="lblApellidoMaternoView" runat="server" CssClass="profile-value"></asp:Label>
                                </div>
                                    <div class="col-md-6 mb-3">
                                    <span class="profile-label">Fecha de Nacimiento:</span><br />
                                    <asp:Label ID="lblFechaNacimientoView" runat="server" CssClass="profile-value"></asp:Label>
                                </div>
                                    <div class="col-md-6 mb-3">
                                    <span class="profile-label">Correo Electrónico:</span><br />
                                    <asp:Label ID="lblCorreoView" runat="server" CssClass="profile-value"></asp:Label>
                                </div>
                                    <div class="col-md-6 mb-3">
                                    <span class="profile-label">Nº Celular:</span><br />
                                    <asp:Label ID="lblCelularView" runat="server" CssClass="profile-value"></asp:Label>
                                </div>
                                    <div class="col-md-6 mb-3">
                                    <span class="profile-label">Género:</span><br />
                                    <asp:Label ID="lblGeneroView" runat="server" CssClass="profile-value"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlEditProfile" runat="server" Visible="false">
                        <div class="card shadow-sm">
                        <div class="card-header">
                            <h4 class="mb-0"><i class="fa-solid fa-user-pen me-2"></i>Editar Perfil</h4>
                        </div>
                        <div class="card-body">
                            <div class="row g-3">
                                    <div class="col-12">
                                    <label for="<%= txtNombresEdit.ClientID %>" class="form-label">Nombres</label>
                                    <asp:TextBox ID="txtNombresEdit" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="<%= txtApellidoPaternoEdit.ClientID %>" class="form-label">Apellido Paterno</label>
                                    <asp:TextBox ID="txtApellidoPaternoEdit" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="<%= txtApellidoMaternoEdit.ClientID %>" class="form-label">Apellido Materno</label>
                                    <asp:TextBox ID="txtApellidoMaternoEdit" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="<%= txtFechaNacimientoEdit.ClientID %>" class="form-label">Fecha de Nacimiento</label>
                                    <asp:TextBox ID="txtFechaNacimientoEdit" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="<%= ddlGeneroEdit.ClientID %>" class="form-label">Género</label>
                                    <asp:DropDownList ID="ddlGeneroEdit" runat="server" CssClass="form-select">
                                        <asp:ListItem Text="-- Seleccione --" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                                        <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                                        <asp:ListItem Text="Otro" Value="O"></asp:ListItem>
                                        <asp:ListItem Text="Prefiero no decir" Value="N"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-6">
                                    <label for="<%= txtCorreoEdit.ClientID %>" class="form-label">Correo Electrónico</label>
                                    <asp:TextBox ID="txtCorreoEdit" runat="server" CssClass="form-control" TextMode="Email" MaxLength="100"></asp:TextBox>
                                </div>
                                    <div class="col-md-6">
                                    <label for="<%= txtCelularEdit.ClientID %>" class="form-label">Nº Celular</label>
                                    <asp:TextBox ID="txtCelularEdit" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer text-end">
                            <asp:Button ID="btnSaveChanges" runat="server" Text="Guardar Cambios" CssClass="btn btn-success me-2" OnClick="btnSaveChanges_Click" />
                            <asp:Button ID="btnCancelEdit" runat="server" Text="Cancelar" CssClass="btn btn-secondary" OnClick="btnCancelEdit_Click" CausesValidation="false"/>
                        </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>