<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MiPrimeraWeb.Index" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form2" runat="server">
        <div>
            <p style="color:blue;font-weight:bold;">Mi primera página web</p>
            <label style ="color:blue;font-weight:bold;">Nombre </label><input type ="text" id ="txtNombre" name ="txtNombre"/>
            <br />
            <label style ="color:blue;font-weight:bold;">Ciudad </label><input type ="text" id ="txtCiudad" name ="txtCiudad"/>
           <br />
            <input type ="submit" id ="boton" value="ENVIAR" style =" border-width:medium;color:blue;font-weight:bold;"/>
        </div>
        
        <br />
        <div>
              <label style ="color:blue;font-weight:bold;">Password </label> 
              &nbsp;<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:CustomValidator runat="server" id="cusCustom" controltovalidate="txtPassword" onservervalidate="cusCustom_ServerValidate" errormessage="El campo debe contener 8 o más caracteres y debe incluir al menos una letra en mayúsculas,una en minúscula y un número" ForeColor="Red"/>
        </div>
        <asp:Button ID="BtnLogin" runat="server" Text="Login" Font-Bold="True" ForeColor="#0000CC" />
    </form>

</body>
</html>
