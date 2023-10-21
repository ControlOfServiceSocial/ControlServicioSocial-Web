﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PLogin.aspx.cs" Inherits="WebForm_login_PLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<link rel="stylesheet" href="../../Estilos/InicioSession/SInicioSession.css" />
</head>
<body>
    <div class="login-box">
        <img src="../../Imagenes/General/logo.png" alt="Imagen de bienvenida"> <!-- Agregamos la imagen aquí -->
        <h2>Bienvenido</h2>
        <form id="form1" runat="server">
            <div class="user-box">
                    <input type="text" name="" required="">
                    <label>Correo electrónico</label>
                </div>
                <div class="user-box">
                    <input type="password" name="" required="">
                    <label>Contraseña</label>
                </div>
                <button>
                    Iniciar sesión
                </button>        
                <button>
                    Registrarse
                </button>
                <a href="newProyect.html">
                    ¿Olvidó su contraseña?
                </a>
        </form>
    </div>
</body>
</html>
