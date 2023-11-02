<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="PtableroProyecto.aspx.cs" Inherits="WebForm_Proyecto_PtableroProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="../../Estilos/Estudiante/STableroEstudiante.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
            <div>
                <asp:Button ID="btnVer" runat="server" Text="Crear Proyecto" />
                <asp:GridView ID="gvListaProyectos" runat="server" CssClass="tabla" AutoGenerateColumns="false" AllowPaging="true" PageSize="8" OnPageIndexChanging="gvListaProyectos_PageIndexChanging" >
                    <PagerStyle CssClass="pagina-numero" /> 
                    <Columns>
                        <asp:BoundField DataField="IdProyecto" HeaderText="Id Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" Visible="false" />
                        <asp:BoundField DataField="NombreProyecto" HeaderText="Nombre Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaInicioProyecto" HeaderText="Fecha de inicio" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaFinProyecto" HeaderText="Fecha de finalización" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="EstadoProyecto" HeaderText="Estado" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:TemplateField HeaderText="Editar">
                            <ItemTemplate>
                                <a href="#" class="icon-info">
                                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6 icono">
                                        <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                                    </svg>
                                </a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ver más">
                            <ItemTemplate>
                                <asp:HyperLink ID="hlVerInformacion" runat="server" Text=""
                                    NavigateUrl='<%# "~/WebForm/Proyecto/PInfoProyecto.aspx?idProyecto=" + Eval("IdProyecto") %>'
                                    CssClass="icon-info">
                                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6 icono">
                                        <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                                    </svg>
                                </asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Asignar">
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
            </div>
        </form>
</asp:Content>

