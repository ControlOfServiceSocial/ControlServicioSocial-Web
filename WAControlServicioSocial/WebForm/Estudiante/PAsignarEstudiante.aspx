<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PAsignarEstudiante.aspx.cs" Inherits="WebForm_Estudiante_PAsignarEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="../../Estilos/Estudiante/SAsignarEstudiante.css" />
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Work+Sans:wght@200;300;400;500;700&display=swap" rel="stylesheet">
</head>
<body>
    <section class="form">
    <h2 class="form__titulo">Asignar Estudiantes</h2>
    <p class="form__parrafo">Nombre del Proyecto</p>

    <label class="etiqueta__seleccion" for="estudiante">Seleccionar Estudiante:</label>
    <select class="seleccion__opciones" id="estudiante" name="opciones">
        <option value="" disabled="disabled" selected="selected" hidden="hidden">Estudiante</option>
        <option value="opcion1">Juan Perez</option>
        <option value="opcion2">Carlos Torrez</option>
        <option value="opcion3">Karen Cortez</option>
    </select>

    <p class="form__horas">Horas Disponibles: <span>35 horas</span></p>
    <div class="botones__contenedor">
      <button type="button" class="boton__cancelar">Cancelar</button>
      <button type="button" class="boton__aceptar">Aceptar</button>
    </div>
  </section>
</body>
</html>
