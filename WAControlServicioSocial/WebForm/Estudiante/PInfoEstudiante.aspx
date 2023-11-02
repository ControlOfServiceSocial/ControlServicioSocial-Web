 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="PInfoEstudiante.aspx.cs" Inherits="WebForm_Estudiante_PInfoEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="../../Estilos/Estudiante/SInfoEstudiante.css" />
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Work+Sans:wght@200;300;400;500;700&display=swap" rel="stylesheet">
<script type="text/javascript" src="https://www.bing.com/api/maps/mapcontrol?key=Ahzo_9SFE2hHoIUJyb8E7C-1rUwMJe8hK3x939moz-MBeh6LghjnYUZXw2z34x9Q&callback=initializeMap" async defer></script>
</head>
<body onload="initializeMap()">
    <section class="contenedor">
    <div class="boton-retorno">
      <a href="javascript:void(0);" onclick="window.history.back();">
        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
          <path stroke-linecap="round" stroke-linejoin="round" d="M10.5 19.5L3 12m0 0l7.5-7.5M3 12h18" />
        </svg>         
      </a>
    </div>
    <form id="formMain" runat="server">
    <div class="contenedor__secciones seccion">
      <div class="seccion__informacion informacion">
        <h2 class="informacion__titulo">Información del estudiante</h2>
        <div class="informacion__mapas mapa">
          <div class="mapa__inicial inicial">
            <div class="inicial__contenedor" id="mapaInicial">

            </div>
            <p>Ubicación inicial</p>
          </div>
          <div class="mapa__final final">
            <div class="final__contenedor" id="mapaFinal">

            </div>
            <p>Ubicación final</p>
          </div>
        </div>
        <div class="informacion__estudiante">
          <p>Tiempo de contribución: <span>12 horas</span></p>
          <p>Nombre completo: <asp:Label ID="lblNombreEstudiante" runat="server"></asp:Label></p>
          <p>Carrera: <asp:Label ID="lblNombreCarrera" runat="server"></asp:Label></p>
          <p>Horas acumuladas: <span>150 horas</span></p>
        </div>
      </div>
      <div class="seccion__proyectos tipo">
        <div class="tipo__proyecto proyecto">
          <p class="proyecto__titulo">Proyectos:</p>
        
          <asp:GridView ID="gridViewProyectosEstudiante" runat="server" AutoGenerateColumns="False" ShowHeader="false">
            <Columns>
                <asp:BoundField DataField="NombreProyecto" />
            </Columns>
        </asp:GridView>
           
        </div>

        <div class="tipo__certificado">
          <p class="certificado__titulo">Certificados:</p>
       
         <asp:GridView ID="gridViewCertificadosEstudiante" runat="server" AutoGenerateColumns="False" ShowHeader="false">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <p><%# Eval("TituloCertificado") %></p>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <div class="certificado__elemento elemento">
                    <div class="elemento__contenedor-icono">
                        <a class="elemento__icono" href="#">
                            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="mis-estilos-svg">
                                <path stroke-linecap="round" stroke-linejoin="round" d="M3 16.5v2.25A2.25 2.25 0 005.25 21h13.5A2.25 2.25 0 0021 18.75V16.5M16.5 12L12 16.5m0 0L7.5 12m4.5 4.5V3" />
                            </svg>
                        </a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

          


        </div>
      </div>
    </div>
    </form>
  </section>
    <script>
        // Función para inicializar los mapas
        function initializeMaps() {
            // Mapa 1
            var mapOptions1 = {
                credentials: "TU_CLAVE_DE_API",
                center: new Microsoft.Maps.Location(latitudMapa1, longitudMapa1), // Coordenadas del centro del primer mapa
                mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                zoom: 15, // Nivel de zoom
                showLocateMeButton: false,
                showZoomButtons: false,
                showMapTypeSelector: false
            };
            var map1 = new Microsoft.Maps.Map(document.getElementById("mapaInicial"), mapOptions1);

            // Agrega un punto (marcador) al mapa 1
            var pushpin1 = new Microsoft.Maps.Pushpin(map1.getCenter(), {
                title: 'Punto 1', // Título del marcador
                color: 'blue' // Color del marcador
            });
            map1.entities.push(pushpin1);

            // Mapa 2
            var mapOptions2 = {
                credentials: "TU_CLAVE_DE_API",
                center: new Microsoft.Maps.Location(latitudMapa2, longitudMapa2), // Coordenadas del centro del segundo mapa
                mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                zoom: 15, // Nivel de zoom
                showLocateMeButton: false,
                showZoomButtons: false,
                showMapTypeSelector: false,
            };
            var map2 = new Microsoft.Maps.Map(document.getElementById("mapaFinal"), mapOptions2);

            // Agrega un punto (marcador) al mapa 2
            var pushpin2 = new Microsoft.Maps.Pushpin(map2.getCenter(), {
                title: 'Punto 2', // Título del marcador
                color: 'red' // Color del marcador
            });
            map2.entities.push(pushpin2);
        }

        // Llama a la función de inicialización cuando la página se cargue
        window.onload = initializeMaps;
    </script>
</body>
</html>
