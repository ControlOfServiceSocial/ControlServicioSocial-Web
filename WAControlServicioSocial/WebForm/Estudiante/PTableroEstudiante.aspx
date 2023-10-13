<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="PTableroEstudiante.aspx.cs" Inherits="WebForm_Estudiante_TableroEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="../../Estilos/Estudiante/STableroEstudiante.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form1" runat="server">
      <section class="contenedor-principal">
  <div class="contenedor-tabla">
    <asp:GridView ID="gvListaEstudiantes" runat="server" CssClass="tabla" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="IdEstudiante" HeaderText="Id Estudiante" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" Visible="false" />
            <asp:BoundField DataField="NombreEstudiante" HeaderText="Nombre completo" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
            <asp:BoundField DataField="ApellidoPaternoEstudiante" HeaderText="Apellido" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
            <asp:BoundField DataField="EmailEstudiante" HeaderText="Correo electronico" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
            <asp:TemplateField HeaderText="Ver información">
                <ItemTemplate>
                    <a href="#" class="icon-info">
                        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6 icono">
                            <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                        </svg>
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>


    <div class="paginacion">
      <p class="paginacion__texto">Mostrando M de N estudiantes</p>

      <div class="paginacion__elementos">
        <span class="etiqueta-paginacion">Página</span>
        <span>
          <svg xmlns="http://www.w3.org/2000/svg" width="12" height="20" viewBox="0 0 12 20" fill="none">
            <path d="M12 18.9325L12 1.06752C12 0.643602 11.5056 0.412025 11.1799 0.683411L0.460933 9.61589C0.221056 9.81579 0.221056 10.1842 0.460934 10.3841L11.1799 19.3166C11.5056 19.588 12 19.3564 12 18.9325Z" fill="#8C4975"/>
          </svg>
        </span>
        <div class="pagina-seleccionada">
          <span>1</span>
        </div>
        <span>2</span>
        <span>
          <svg xmlns="http://www.w3.org/2000/svg" width="12" height="20" viewBox="0 0 12 20" fill="none">
            <path d="M2.25768e-07 1.06752L1.27301e-08 18.9325C7.67488e-09 19.3564 0.494428 19.588 0.820091 19.3166L11.5391 10.3841C11.7789 10.1842 11.7789 9.81579 11.5391 9.61589L0.820092 0.683411C0.494429 0.412024 2.30823e-07 0.643602 2.25768e-07 1.06752Z" fill="#8C4975"/>
          </svg>
        </span>
      </div>
    </div>
  </div>
</section>
     </form>
</asp:Content>

