<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PInfoEstudiante.aspx.cs" Inherits="WebForm_Estudiante_PInfoEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="../../Estilos/Estudiante/CInfoEstudiante.css" />
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Work+Sans:wght@200;300;400;500;700&display=swap" rel="stylesheet">
</head>
<body>
    <<section class="contenedor">
    <div class="boton-retorno">
      <a href="#">
        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
          <path stroke-linecap="round" stroke-linejoin="round" d="M10.5 19.5L3 12m0 0l7.5-7.5M3 12h18" />
        </svg>         
      </a>
    </div>
    <div class="contenedor__secciones seccion">
      <div class="seccion__informacion informacion">
        <h2 class="informacion__titulo">Información del estudiante</h2>
        <div class="informacion__mapas mapa">
          <div class="mapa__inicial inicial">
            <div class="inicial__contenedor">

            </div>
            <p>Ubicación inicial</p>
          </div>
          <div class="mapa__final final">
            <div class="final__contenedor">

            </div>
            <p>Ubicación final</p>
          </div>
        </div>
        <div class="informacion__estudiante">
          <p>Tiempo de contribución: <span>12 horas</span></p>
          <p>Nombre completo: <span>Juan Perez</span></p>
          <p>Carrera: <span>Ing. Comercial</span></p>
          <p>Horas acumuladas: <span>150 horas</span></p>
        </div>
      </div>
      <div class="seccion__proyectos tipo">
        <div class="tipo__proyecto proyecto">
          <p class="proyecto__titulo">Proyectos:</p>

          <div class="proyecto__elemento elemento">
            <p class="elemento__nombre">Nombre proyecto</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                </svg>              
              </a>
            </div>
          </div>

          <div class="proyecto__elemento elemento">
            <p class="elemento__nombre">Nombre proyecto</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                </svg>              
              </a>
            </div>
          </div>

          <div class="proyecto__elemento elemento">
            <p class="elemento__nombre">Nombre proyecto</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                </svg>              
              </a>
            </div>
          </div>

          <div class="proyecto__elemento elemento">
            <p class="elemento__nombre">Nombre proyecto</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                </svg>              
              </a>
            </div>
          </div>
        </div>
        <div class="tipo__certificado">
          <p class="certificado__titulo">Certificados:</p>

          <div class="certificado__elemento elemento">
            <p class="elemento__nombre">Nombre certificado</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M3 16.5v2.25A2.25 2.25 0 005.25 21h13.5A2.25 2.25 0 0021 18.75V16.5M16.5 12L12 16.5m0 0L7.5 12m4.5 4.5V3" />
                </svg>                
              </a>
            </div>
          </div>

          <div class="certificado__elemento elemento">
            <p class="elemento__nombre">Nombre certificado</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M3 16.5v2.25A2.25 2.25 0 005.25 21h13.5A2.25 2.25 0 0021 18.75V16.5M16.5 12L12 16.5m0 0L7.5 12m4.5 4.5V3" />
                </svg>                
              </a>
            </div>
          </div>

          <div class="certificado__elemento elemento">
            <p class="elemento__nombre">Nombre certificado</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M3 16.5v2.25A2.25 2.25 0 005.25 21h13.5A2.25 2.25 0 0021 18.75V16.5M16.5 12L12 16.5m0 0L7.5 12m4.5 4.5V3" />
                </svg>                
              </a>
            </div>
          </div>

          <div class="certificado__elemento elemento">
            <p class="elemento__nombre">Nombre certificado</p>
            <div class="elemento__contenedor-icono">
              <a class="elemento__icono" href="#">
                <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="black" class="w-6 h-6">
                  <path stroke-linecap="round" stroke-linejoin="round" d="M3 16.5v2.25A2.25 2.25 0 005.25 21h13.5A2.25 2.25 0 0021 18.75V16.5M16.5 12L12 16.5m0 0L7.5 12m4.5 4.5V3" />
                </svg>                
              </a>
            </div>
          </div>

        </div>
      </div>
    </div>
  </section>
</body>
</html>
