<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCrearProyecto.aspx.cs" Inherits="WebForm_Proyecto_PCrearProyecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../../Estilos/Proyecto/SCrearProyecto.css" />
</head>
<body>
    <a href="login.html" >
        <img src="image/atras 1.png" alt="Imagen de bienvenida" >
    </a>
  <div class="proyect-box">
    <form ID="form1" runat="server">
        <h2>Crear proyecto nuevo</h1>
      <div class="form-row">
        <div class="form-item">
          <label for="nombre">Nombre del proyecto *</label>
          <input type="text" ID="txtnombre" runat="server" name="nombre" placeholder="Ingrese el nombre del proyecto" required>
        </div>
        <div class="form-item">
            <label for="ubicacion">Ubicación del proyecto *</label>
            <input type="text" ID="ubicacion" runat="server" name="ubicacion" placeholder="Ingrese el lugar del proyecto" required>
        </div>
        <div class="form-item">
            <label for="inicio">Fecha de inicio *</label>
            <input type="date" ID="inicio" runat="server" name="inicio" required>
        </div>   
      </div>
      <div class="form-row">
        <div class="form-item">
            <label for="fin">Fecha de finalización *</label>
            <input type="date" ID="fin" runat="server" name="fin" required>
        </div>      
        <div class="form-item">
            <label for="creacion">Fecha de creación *</label>
            <input type="date" ID="creacion" runat="server" name="creacion" required>
        </div>
        <div class="form-item">
            <label for="estado">Estado *</label>
            <select ID="estado" runat="server" name="estado" required>
              <option value="">-- Seleccionar --</option>
              <option value="iniciado">Iniciado</option>
              <option value="en proceso">En Proceso</option>
              <option value="finalizado">Finalizado</option>
            </select>
        </div>
      </div>
      <div class="form-row">
        <div class="form-item">
            <label for="sede">Sede del proyecto *</label>
            <select ID="sede" runat="server" name="sede" required>
              <option value="">-- Seleccionar --</option>
              <option value="sede1">Sede 1</option>
              <option value="sede2">Sede 2</option>
              <option value="sede3">Sede 3</option>
            </select>
        </div> 
        <div class="form-item">
            <label for="imagen">Imagen *</label>
            <label ID="imageFile"> Cargar Imagen
              <asp:input type="file" ID="imagen" runat="server" name="imagen" accept="image/*" required>
            </label>      
        </div>     
        <div class="form-item">
          <label for="horas">Asignar horas *</label>
          <input type="number" ID="horas" runat="server" name="horas" placeholder="Ingrese la cantIDad de horas de proyecto" required>
        </div>
             
      </div>
      <div class="form-row">       
        <div class="form-item">
            <label for="desc">Descripción del proyecto</label>
            <textarea ID="desc" runat="server" name="desc" placeholder="Ingrese la descripción del proyecto"></textarea>
          </div>
        <div class="form-row">
            <div class="form-item">
                <input type="button" ID="btnCancelar" runat="server" value="Cancelar">
            </div>
            <div class="form-item">
                <input type="submit" id="btnCrear" runat="server" value="Crear Proyecto">
            </div>           
        </div>
      </div>
      <div class="form-row">
        <label ID="advertencia">Los campos marcados con ‘*’ son de carácter obligatorio.</label>
      </div>
    </form>
      </div>
</body>
</html>
