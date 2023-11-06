<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PInfoProyecto.aspx.cs" Inherits="WebForm_Proyecto_PInfoProyecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="../../Estilos/Proyecto/SInfoProyecto.css" />
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Work+Sans:wght@200;300;400;500;700&display=swap" rel="stylesheet">
</head>
<body>
    <div class="boton-retorno">
    <a href="javascript:void(0);" onclick="window.history.back();">
      <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
        <path stroke-linecap="round" stroke-linejoin="round" d="M10.5 19.5L3 12m0 0l7.5-7.5M3 12h18" />
      </svg>         
    </a>
  </div>
  <section class="contenedor-info">
    <div class="contenedor-info__titulo">
      <h2><asp:Label ID="lblSubtitulo" runat="server"></asp:Label></h2>
    </div>

    <div class="contenedor-info__informacion-proyecto">
      <section class="informacion-proyecto__imagen">
        <asp:Image ID="imgProyecto" runat="server" AlternateText="Imagen del proyecto" />
      </section>
      <section class="informacion-proyecto__datos1">
        <div>
          <p>Nombre del proyecto:</p>
          <p><asp:Label ID="lblNombreProyecto" runat="server"></asp:Label></p>
        </div>
        <div>
          <p>Fecha de inicio:</p>
          <p><asp:Label ID="lblFechaInicio" runat="server"></asp:Label></p>
        </div>
        <div>
          <p>Fecha de creación:</p>
          <p><asp:Label ID="lblFechaCreacion" runat="server"></asp:Label></p>
        </div>
        <div>
          <p>Sede del proyecto:</p>
          <p><asp:Label ID="lblSede" runat="server"></asp:Label></p>
        </div>
      </section>

      <section class="informacion-proyecto__datos2">
        <div>
          <p>Ubicación del proyecto:</p>
          <p><asp:Label ID="lblUbicacion" runat="server"></asp:Label></p>
        </div>
        <div>
          <p>Fecha de finalización:</p>
          <p><asp:Label ID="lblFechaFin" runat="server"></asp:Label></p>
        </div>
        <div>
          <p>Estado:</p>
          <p><asp:Label ID="lblEstado" runat="server"></asp:Label></p>
        </div>
        <div>
          <p>Horas estimadas:</p>
          <p><asp:Label ID="lblHorasEstimadas" runat="server"></asp:Label></p>
        </div>
      </section>
    </div>

    <div class="contenedor-info__descripcion">
      <p>Descripción del proyecto:</p>
      <p><asp:Label ID="lblDescripcion" runat="server"></asp:Label></p>
    </div>
  </section>
</body>
</html>
