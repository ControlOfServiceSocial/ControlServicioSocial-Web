<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCrearProyecto.aspx.cs" Inherits="WebForm_Proyecto_PCrearProyecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../../Estilos/Proyecto/SCrearProyecto.css" />
</head>
<body>
        <img src="../../Imagenes/General/atras.png" alt="Imagen de bienvenida" />

  <div class="proyect-box">
    <form ID="form1" runat="server">
        <h2>Crear proyecto nuevo</h2>
      <div class="form-row">
        <div class="form-item">
          <label for="nombre">Nombre del proyecto *</label>
          <asp:TextBox type="text" ID="txtnombre" runat="server" name="nombre" placeholder="Ingrese el nombre del proyecto"></asp:TextBox>
        </div>
        <div class="form-item">
            <label for="ubicacion">Ubicación del proyecto *</label>
            <asp:TextBox type="text" ID="ubicacion" runat="server" name="ubicacion" placeholder="Ingrese el lugar del proyecto" ></asp:TextBox>
        </div>
        <div class="form-item">
            <label for="inicio">Fecha de inicio *</label>
            <asp:Calendar ID="inicio" runat="server"></asp:Calendar>
        </div>   
      </div>
      <div class="form-row">
        <div class="form-item">
            <label for="fin">Fecha de finalización *</label>
            <asp:Calendar ID="fin" runat="server"></asp:Calendar>
        </div>      
        <div class="form-item">
            <label for="creacion">Fecha de creación *</label>
            <asp:Calendar ID="creacion" runat="server"></asp:Calendar>
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
              <asp:ListItem value="sede1">Sede 1</asp:ListItem>
              <asp:ListItem value="sede2">Sede 2</asp:ListItem>
              <asp:ListItem value="sede3">Sede 3</asp:ListItem>
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
                <input type="button" ID="btnCancelar" runat="server" value="Cancelar">
            </div>
            <div class="form-item">
                <asp:Button ID="btnSend" runat="server" Text="Crear Proyecto"  OnClick="btnSend_Click"/>
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
