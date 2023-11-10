<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="PtableroProyecto.aspx.cs" Inherits="WebForm_Proyecto_PtableroProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="../../Estilos/Estudiante/STableroEstudiante.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="proyect-box">
        <h2>Control de servicio social</h2>
        <form id="form1" runat="server">
            <div>            
                <asp:GridView ID="gvListaProyectos" runat="server" CssClass="tabla" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" OnPageIndexChanging="gvListaProyectos_PageIndexChanging" OnRowCommand="gvListaProyectos_RowCommand" style="border-radius: 5px;
border: 1px solid #E9EFF4;
background: #FFF;
width: 1041px;
height: 55px;
flex-shrink: 0;
">
                    <Columns>
                        <asp:BoundField DataField="IdProyecto" HeaderText="Id Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" Visible="true" />
                        <asp:BoundField DataField="NombreProyecto" HeaderText="Nombre Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaInicioProyecto" HeaderText="Fecha de inicio" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaFinProyecto" HeaderText="Fecha de finalización" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="EstadoProyecto" HeaderText="Estado" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:ButtonField HeaderText="Editar" ButtonType="Button" CommandName="btnActualizar" Text="Editar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
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
                <asp:HyperLink ID="hlAsignarEstudiante" runat="server" Text=""
                    NavigateUrl='<%# "~/WebForm/Estudiante/PAsignarEstudiante.aspx?idProyecto=" + Eval("IdProyecto") %>'
                    CssClass="icon-info">
                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-6 h-6 icono">
                        <path stroke-linecap="round" stroke-linejoin="round" d="M11.25 11.25l.041-.02a.75.75 0 011.063.852l-.708 2.836a.75.75 0 001.063.853l.041-.021M21 12a9 9 0 11-18 0 9 9 0 0118 0zm-9-3.75h.008v.008H12V8.25z" />
                    </svg>
                </asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <div class="form-row">
                    <div class="form-item" style="float: right;margin-top: 20px">
                        <asp:Button ID="btnVer" OnClick="btnVer_Click" runat="server" Text="Crear Proyecto" ControlStyle-BackColor="#8C4975" ControlStyle-ForeColor="White" ControlStyle-Width="182px" ControlStyle-BorderRadius="7" ControlStyle-CssClass="boton" CssClass="btnasd"/>
                    </div>
                </div>
                
            </div>
        </form>
    </div>
</asp:Content>

