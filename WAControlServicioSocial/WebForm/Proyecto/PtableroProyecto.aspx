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
                        <asp:ButtonField HeaderText="Ver más" ButtonType="Button" CommandName="btnVer" Text="ver" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
                        <asp:ButtonField HeaderText="Asignar" ButtonType="Button" CommandName="btnAsignar" Text="Asignar" ControlStyle-BackColor="#64072D" ControlStyle-ForeColor="White" ControlStyle-Width="55" ControlStyle-Height="20" ControlStyle-BorderColor="#64072D" ControlStyle-CssClass="boton" />
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
</body>
</html>
