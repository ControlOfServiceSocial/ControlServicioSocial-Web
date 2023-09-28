<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PInfoProyecto.aspx.cs" Inherits="WebForm_Proyecto_PInfoProyecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="../../Estilos/Proyecto/CInfoProyecto.css" />
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Work+Sans:wght@200;300;400;500;700&display=swap" rel="stylesheet">
</head>
<body>
    <div class="boton-retorno">
    <a href="">
      <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
        <path stroke-linecap="round" stroke-linejoin="round" d="M10.5 19.5L3 12m0 0l7.5-7.5M3 12h18" />
      </svg>         
    </a>
  </div>
  <section class="contenedor-info">
    <div class="contenedor-info__titulo">
      <h2>Proyecto de colaboración con la comunidad</h2>
    </div>

    <div class="contenedor-info__informacion-proyecto">
      <section class="informacion-proyecto__imagen">
        <img src="../../Imagenes/Proyecto/imagen.png" alt="">
      </section>
      <section class="informacion-proyecto__datos1">
        <div>
          <span>Nombre del proyecto:</span>
          <p>Proyecto de ayuda comunitaria</p>
        </div>
        <div>
          <span>Fecha de inicio:</span>
          <p>23/08/2023</p>
        </div>
        <div>
          <span>Fecha de creación:</span>
          <p>23/08/2023</p>
        </div>
        <div>
          <span>Sede del proyecto:</span>
          <p>Sede de tiquipaya</p>
        </div>
      </section>

      <section class="informacion-proyecto__datos2">
        <div>
          <span>Ubicación del proyecto:</span>
          <p>Cochabamba</p>
        </div>
        <div>
          <span>Fecha de finalización:</span>
          <p>23/08/2023</p>
        </div>
        <div>
          <span>Estado:</span>
          <p>Activo</p>
        </div>
        <div>
          <span>Horas asignadas:</span>
          <p>50 horas</p>
        </div>
      </section>
    </div>

    <div class="contenedor-info__descripcion">
      <span>Descripción del proyecto:</span>
      <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Impedit, culpa! Quo iure minus cumque voluptas sequi cupiditate accusantium facere ad, earum odit non mollitia blanditiis. Iusto animi quae minus cum!
      Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, voluptatem! Laboriosam, itaque, facere ipsam alias doloribus a ratione pariatur repudiandae veniam quidem nulla. Aut aliquid accusamus modi, voluptatibus quaerat quibusdam.
      </p>
    </div>
  </section>
</body>
</html>
