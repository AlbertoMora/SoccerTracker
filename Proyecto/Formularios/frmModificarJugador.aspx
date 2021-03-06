﻿<%@ Page Language="C#" MasterPageFile="~/Formularios/ProyectoMaster.Master" AutoEventWireup="true" CodeBehind="frmModificarJugador.aspx.cs" Inherits="Proyecto.Formularios.frmModificarJugador" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server" class="text-center">
        <label class="mb-1">Nombre del jugador seleccionado</label>
        <br />
        <asp:TextBox runat="server" disabled="disabled" ID="txtNombreJugador" class="form-control md-textbox btn" />
        <br />

        <label class="mb-1">Equipo</label>
        <asp:RequiredFieldValidator CssClass="validator-message" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="ddlEquipo"></asp:RequiredFieldValidator>
        <asp:DropDownList runat="server" ID="ddlEquipo">
        </asp:DropDownList>
        <br />
        <br />
        <label class="mb-1">Posición</label>
        <asp:RequiredFieldValidator CssClass="validator-message" ID="RequiredFieldValidator2" runat="server"
            ErrorMessage="Este campo es requerido" ControlToValidate="ddlPosicion"></asp:RequiredFieldValidator>
        <asp:DropDownList runat="server" ID="ddlPosicion">
        </asp:DropDownList>
        <br />
        <asp:Button Text="Guardar" ID="btnSubmit" class="btn btn-alter btn-xl" runat="server" OnClick="btnSubmit_Click" />
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    </form>
</asp:Content>
