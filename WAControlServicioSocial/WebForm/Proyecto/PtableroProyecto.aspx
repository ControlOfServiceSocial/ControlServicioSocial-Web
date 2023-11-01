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
                <asp:Button ID="btnVer" OnClick="btnVer_Click" runat="server" Text="Crear Proyecto" />
                <asp:GridView ID="gvListaProyectos" runat="server" CssClass="tabla" AutoGenerateColumns="false" AllowPaging="true" PageSize="8" OnPageIndexChanging="gvListaProyectos_PageIndexChanging" OnRowCommand="gvListaProyectos_RowCommand">
                    <PagerStyle CssClass="pagina-numero" /> 
                    <Columns>
                        <asp:BoundField DataField="IdProyecto" HeaderText="Id Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" Visible="true" />
                        <asp:BoundField DataField="NombreProyecto" HeaderText="Nombre Proyecto" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaInicioProyecto" HeaderText="Fecha de inicio" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="FechaFinProyecto" HeaderText="Fecha de finalización" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:BoundField DataField="EstadoProyecto" HeaderText="Estado" ItemStyle-CssClass="tabla__cuerpo" HeaderStyle-CssClass="tabla__encabezado" />
                        <asp:ButtonField ButtonType="Button" CommandName="btnVer" Text="Ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                        <asp:ButtonField ButtonType="Button" CommandName="btnCancelar" Text="Eliminar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                        <asp:ButtonField ButtonType="Button" CommandName="btnActualizar" Text="Actualizar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                    </Columns>
                </asp:GridView>
            </div>
        </form>
    </div>
</body>
</html>
