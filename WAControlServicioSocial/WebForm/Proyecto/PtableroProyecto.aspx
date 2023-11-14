<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PtableroProyecto.aspx.cs" Inherits="WebForm_Proyecto_PtableroProyecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../../Estilos/Proyecto/STableroProyecto.css" />
</head>
    
<body>
    <div class="proyect-box">
        <h2>Control de servicio social</h2>
        <form id="form1" runat="server">
            <div>            
                <asp:GridView ID="gvListaProyectos" runat="server" CssClass="tabla" AutoGenerateColumns="false" AllowPaging="true" PageSize="8" OnPageIndexChanging="gvListaProyectos_PageIndexChanging" style="border-radius: 5px;
border: 1px solid #E9EFF4;
background: #FFF;
width: 1000px;
height: 55px;
flex-shrink: 0;
text-align:center;
">
                    <PagerStyle CssClass="pagina-numero" HorizontalAlign="Center"/> 
                    <Columns>
                        <asp:BoundField DataField="IdProyecto" HeaderText="Id Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" Visible="false" />
                        <asp:BoundField DataField="NombreProyecto" HeaderText="Nombre Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaInicioProyecto" HeaderText="Fecha de inicio" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaFinProyecto" HeaderText="Fecha de finalización" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="EstadoProyecto" HeaderText="Estado" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />                       
                        <asp:TemplateField HeaderText="Editar">
                            <ItemTemplate>
                                <asp:HyperLink ID="hlVerInformacion" runat="server" Text=""
                                    NavigateUrl='<%# "~/WebForm/Proyecto/PCrearProyecto.aspx?idProyecto=" + Eval("IdProyecto") %>'
                                    CssClass="icon-info">
                                    <svg enable-background="new 0 0 64 64" height="20" id="Layer_1" version="1.1" viewBox="0 0 64 64" width="20" xml:space="preserve" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
<g>
<path d="M55.736,13.636l-4.368-4.362c-0.451-0.451-1.044-0.677-1.636-0.677c-0.592,0-1.184,0.225-1.635,0.676l-3.494,3.484   l7.639,7.626l3.494-3.483C56.639,15.998,56.639,14.535,55.736,13.636z"/>
<polygon points="21.922,35.396 29.562,43.023 50.607,22.017 42.967,14.39  "/>
<polygon points="20.273,37.028 18.642,46.28 27.913,44.654  "/>
<path d="M41.393,50.403H12.587V21.597h20.329l5.01-5H10.82c-1.779,0-3.234,1.455-3.234,3.234v32.339   c0,1.779,1.455,3.234,3.234,3.234h32.339c1.779,0,3.234-1.455,3.234-3.234V29.049l-5,4.991V50.403z"/>
</g>
</svg>
                                </asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ver más">
                <ItemTemplate>
                    <asp:HyperLink ID="hlVerInformacion" runat="server" Text=""
                        NavigateUrl='<%# "~/WebForm/Proyecto/PInfoProyecto.aspx?idProyecto=" + Eval("IdProyecto") %>'
                        CssClass="icon-info">
                        <svg xmlns="http://www.w3.org/2000/svg" fill="none"  width="20" height="20" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6 icono">
                            <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                        </svg>
                    </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Asignar">
            <ItemTemplate>
                <asp:HyperLink ID="hlAsignarEstudiante" runat="server" Text=""
                    NavigateUrl='<%# "~/WebForm/Estudiante/PAsignarEstudiante.aspx?idProyecto=" + Eval("IdProyecto") %>'
                    CssClass="icon-info">
                    <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-user-plus" width="20" height="20" viewBox="0 0 24 24" stroke-width="1.5" stroke="#2c3e50" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path stroke="none" d="M0 0h24v24H0z" fill="none"/>
  <path d="M8 7a4 4 0 1 0 8 0a4 4 0 0 0 -8 0" />
  <path d="M16 19h6" />
  <path d="M19 16v6" />
  <path d="M6 21v-2a4 4 0 0 1 4 -4h4" />
</svg>
                </asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        Aún no se tiene proyectos registrados.
                    </EmptyDataTemplate>
                </asp:GridView>
                <div class="form-row">
                    <div class="form-item" style="float: right;margin-top: 20px">
                        <asp:Button ID="btnVer" OnClick="btnVer_Click" runat="server" Text="Crear Proyecto" ControlStyle-BackColor="#8C4975" ControlStyle-ForeColor="White" ControlStyle-Width="182px" ControlStyle-BorderRadius="7" ControlStyle-CssClass="boton" CssClass="btnasd"/>
                    </div>
                </div>
                
            </div>
        </form>
    </div>
</body>
</html>
