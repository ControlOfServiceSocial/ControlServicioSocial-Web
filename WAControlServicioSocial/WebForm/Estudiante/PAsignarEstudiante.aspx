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
    <form runat="server">
    <div class="boton-retorno">
      <a href="../Proyecto/PtableroProyecto.aspx">
        <svg xmlns="http://www.w3.org/2000/svg" fill="none" color="black" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6">
          <path stroke-linecap="round" stroke-linejoin="round" d="M10.5 19.5L3 12m0 0l7.5-7.5M3 12h18" />
        </svg>         
      </a>
    </div>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <section class="form">
        <h2 class="form__titulo">Asignar Estudiantes</h2>
        <asp:Label ID="lblNombreProyecto" runat="server" CssClass="form__parrafo"></asp:Label>

        <label class="etiqueta__seleccion" for="estudiante">Seleccionar Estudiante:</label>
        <input list="estudiantes" name="estudiante" id="estudiante" class="seleccion__opciones">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <datalist id="estudiantes">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <option value="<%# GetNombreCompleto((SWLNControlServicioSocial.ECEstudiante)Container.DataItem) %>">
                        </ItemTemplate>
                    </asp:Repeater>
                </datalist>
                <asp:Label ID="LabelError" runat="server" CssClass="form__parrafo"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>

        <p class="form__horas">Horas Estimadas: <asp:Label ID="lblHorasEstimadas" runat="server"></asp:Label></p>
        <div class="botones__contenedor">
            <button type="button" class="boton__cancelar" onclick="confirmarCancelacion()">Cancelar</button>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnAceptar" CssClass="boton__aceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" OnClientClick="clearInput()" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </section>
</form>

  <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script type="text/javascript">
        function clearInput() {
            var estudianteSeleccionado = document.getElementById('estudiante').value;
            document.getElementById('<%= HiddenField1.ClientID %>').value = estudianteSeleccionado;
            document.getElementById('estudiante').value = '';
        }
        function confirmarCancelacion() {
            Swal.fire({
                title: '¿Estás seguro?',
                text: "¿Quieres cancelar la operación?",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Sí, cancelar!',
                cancelButtonText: 'No, volver'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = "/WebForm/Proyecto/PtableroProyecto.aspx";
                }
            })
        }
    </script>
</body>
</html>
