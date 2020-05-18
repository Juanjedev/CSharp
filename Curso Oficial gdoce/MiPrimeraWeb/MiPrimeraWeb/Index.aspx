<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MiPrimeraWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server" action="Bienvenida.aspx" method="post">
        <div>
            <p style="color:blue;font-weight:bold;">Mi primera página web</p>
            <label style ="color:blue;font-weight:bold;">Nombre </label><input type ="text" id ="txtNombre" name ="txtNombre"/>
            <br />
            <label style ="color:blue;font-weight:bold;">Ciudad </label><input type ="text" id ="txtCiudad" name ="txtCiudad"/>
           <br />
            <input type ="submit" id ="boton" value="ENVIAR" style =" border-width:medium;color:blue;font-weight:bold;"/>
        </div>
        
    </form>

</body>
</html>
