﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Formularios/ProyectoMaster.Master" AutoEventWireup="true" CodeBehind="frmEliminarTorneo.aspx.cs" Inherits="Proyecto.Formularios.frmEliminarTorneo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form style="text-align:center;" id="form1" runat="server">
        <h2>¿Desea eliminar definitivamente el torneo seleccionado?</h2>
        <asp:Button Text="Sí" ID="btnSi" class="btn btn-alter btn-xl" runat="server" OnClick="btnSi_Click" /> 
        <asp:Button Text="No" ID="btnNo" class="btn btn-cancel btn-xl" runat="server" OnClick="btnNo_Click" />
    </form>

</asp:Content>
