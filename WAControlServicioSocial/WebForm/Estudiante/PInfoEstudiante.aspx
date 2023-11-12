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
<script type="text/javascript" src="https://www.bing.com/api/maps/mapcontrol?key=Ahzo_9SFE2hHoIUJyb8E7C-1rUwMJe8hK3x939moz-MBeh6LghjnYUZXw2z34x9Q&callback=initializeMap"></script>
</head>
<body onload="initializeMap()">
    <section class="contenedor">
    <div class="boton-retorno">
      <a href="PTableroEstudiante.aspx">
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
          <p>Tiempo de contribución: <asp:Label ID="lblTiempoContribucion" runat="server"></asp:Label></p>
          <p>Nombre completo: <asp:Label ID="lblNombreEstudiante" runat="server"></asp:Label></p>
          <p>Carrera: <asp:Label ID="lblNombreCarrera" runat="server"></asp:Label></p>
          
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
      </div>
      <div class="seccion__proyectos tipo">
          <p class="horas__totales">Total de horas acumuladas: <asp:Label ID="lblHorasTotales" runat="server"></asp:Label></p>
        <p class="proyecto__titulo">Proyectos:</p>
        <div class="tipo__proyecto proyecto">
          <asp:GridView ID="gridViewProyectosEstudiante" runat="server" CssClass="miGridView" AutoGenerateColumns="False" ShowHeader="false" DataKeyNames="IdProyecto"
              OnSelectedIndexChanged="GridViewProyectosEstudiante_SelectedIndexChanged" AutoGenerateSelectButton="true">
              <SelectedRowStyle BackColor="LightGray" ForeColor="Black" />
            <Columns>
                 
                <asp:BoundField DataField="NombreProyecto" />
            </Columns>
        </asp:GridView>
           
        </div>

        <p class="certificado__titulo">Certificados:</p>
        <div class="tipo__certificado">
       
         <asp:GridView ID="gridViewCertificadosEstudiante" runat="server" AutoGenerateColumns="False" ShowHeader="false" OnRowCommand="gridViewCertificadosEstudiante_RowCommand">
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
                    <asp:LinkButton ID="lnkDescargar" CssClass="elemento__icono" CommandArgument='<%# Eval("DocumentoCertificado") %>' CommandName="Descargar" runat="server">
                        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="mis-estilos-svg">
                            <path stroke-linecap="round" stroke-linejoin="round" d="M3 16.5v2.25A2.25 2.25 0 005.25 21h13.5A2.25 2.25 0 0021 18.75V16.5M16.5 12L12 16.5m0 0L7.5 12m4.5 4.5V3" />
                        </svg>
                    </asp:LinkButton>
                </div>
                </div>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        El estudiante aún no tiene certificados cargados.
    </EmptyDataTemplate>
</asp:GridView>

          


        </div>
      </div>
    </div>
    </form>
  </section>
    <script>
        // Función para crear un mapa
        function createMap(elementId, latitude, longitude, pinColor) {
            var mapOptions = {
                credentials: "Ahzo_9SFE2hHoIUJyb8E7C-1rUwMJe8hK3x939moz-MBeh6LghjnYUZXw2z34x9Q",
                center: new Microsoft.Maps.Location(latitude, longitude),
                mapTypeId: Microsoft.Maps.MapTypeId.aerial,
                zoom: 15,
                showLocateMeButton: false,
                showZoomButtons: false,
                showMapTypeSelector: false
            };
            var map = new Microsoft.Maps.Map(document.getElementById(elementId), mapOptions);

            // Agrega un punto (marcador) al mapa
            var pushpin = new Microsoft.Maps.Pushpin(map.getCenter(), {
                title: 'Punto', // Título del marcador
                color: pinColor // Color del marcador
            });
            map.entities.push(pushpin);

            return map;
        }

        // Función para inicializar los mapas
        function initializeMaps() {
            // Mapa 1
            var map1 = createMap("mapaInicial", latitudMapa1, longitudMapa1, 'blue');

            // Mapa 2
            var map2 = createMap("mapaFinal", latitudMapa2, longitudMapa2, 'red');
        }

        // Llama a la función de inicialización cuando la página se cargue
        window.onload = initializeMaps;
    </script>
</body>
</html>