﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCrearProyecto.aspx.cs" Inherits="WebForm_Proyecto_PCrearProyecto" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../../Estilos/Proyecto/SCrearProyecto.css" />
</head>
<body>
  <div class="boton-retorno">
  <a href="../Proyecto/PtableroProyecto.aspx">
    <svg xmlns="http://www.w3.org/2000/svg" fill="none" color="black" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
      <path stroke-linecap="round" stroke-linejoin="round" d="M10.5 19.5L3 12m0 0l7.5-7.5M3 12h18" />
    </svg>         
  </a>
</div>
  <div class="proyect-box">
    <form ID="form1" runat="server">
        <h2 runat="server" id="h2Title">Crear proyecto nuevo</h2>
      <div class="form-row">
        <div class="form-item">
          <label for="nombre">Nombre del proyecto *</label>
          <asp:TextBox type="text" ID="txtnombre" runat="server" name="nombre" placeholder="Ingrese el nombre del proyecto" MaxLength="50"></asp:TextBox>
        </div>
        <div class="form-item">
            <label for="ubicacion">Ubicación del proyecto *</label>
            <asp:TextBox type="text" ID="ubicacion" runat="server" name="ubicacion" MaxLength="50" placeholder="Ingrese el lugar del proyecto" ></asp:TextBox>
        </div>
        <div class="form-item">
            <label for="inicio">Fecha de inicio *</label>
            <asp:TextBox ID="inicio" runat="server" TextMode="Date"></asp:TextBox>
        </div>   
      </div>
      <div class="form-row">
        <div class="form-item">
            <label for="fin">Fecha de finalización *</label>
             <asp:TextBox ID="fin" runat="server" TextMode="Date"></asp:TextBox>
        </div>      
        <div class="form-item">
            <label for="creacion">Fecha de creación *</label>
            <asp:TextBox ID="creacion" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div class="form-item">
            <label for="estado">Estado *</label>
            <asp:DropDownList ID="estado" runat="server" name="estado">
              <asp:ListItem value="0">-- Seleccionar --</asp:ListItem>
              <asp:ListItem value="1">Activo</asp:ListItem>
              <asp:ListItem value="2">Finalizado</asp:ListItem>
              <asp:ListItem value="3">Completo</asp:ListItem>
            </asp:DropDownList>
        </div>
      </div>
      <div class="form-row">
        <div class="form-item">
            <label for="sede">Sede del proyecto *</label>
            <asp:DropDownList ID="sede" runat="server" name="sede" required>
              <asp:ListItem value="">-- Seleccionar --</asp:ListItem>
              <asp:ListItem value="1">Tiquipaya</asp:ListItem>
              <asp:ListItem value="2">America</asp:ListItem>
              <asp:ListItem value="3">Ayacucho</asp:ListItem>
            </asp:DropDownList>
        </div> 
        <div class="form-item">
            <label for="imagen">Imagen *</label>
            <label ID="imageFile"> Cargar Imagen
                <asp:FileUpload ID="img" runat="server" />
            </label>      
        </div>     
        <div class="form-item">
          <label for="horas">Asignar horas *</label>
          <asp:TextBox type="number" ID="horas" runat="server" name="horas" placeholder="Ingrese la cantidad de horas de proyecto"></asp:TextBox>
        </div>
             
      </div>
      <div class="form-row">       
        <div class="form-item">
            <label for="desc">Descripción del proyecto</label>
            <asp:TextBox ID="desc" runat="server" name="desc" placeholder="Ingrese la descripción del proyecto"></asp:TextBox>
          </div>
        <div class="form-row">
            <div class="form-item">
                <input type="button" ID="btnCancelar" runat="server" value="Cancelar" onclick="redireccionarAotraVista();">
            </div>
            <div class="form-item">
                <asp:Button ID="btnSend" runat="server" Text="Crear Proyecto"  OnClick="btnSend_Click"/>
            </div>           
        </div>
      </div>
      <div class="form-row">
        <label ID="advertencia">Los campos marcados con ‘*’ son de carácter obligatorio.</label>
          <label ID="mensaje" runat="server"></label>
      </div>
    </form>
      <script>
        function redireccionarAotraVista() {
            // Puedes usar window.location.href para redireccionar a otra página
            window.location.href = 'PtableroProyecto.aspx';
        }
      </script>
      </div>
</body>
</html>