<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateExample.aspx.cs" Inherits="WebForms.ViewStateExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList runat="server" ID="MyList" AutoPostBack="True" EnableViewState="True" OnSelectedIndexChanged="MyList_SelectedIndexChanged"/>
    </div>
    <div>
        <asp:Button runat="server" ID="MyButton" Text="Clicky"/>
    </div>
    </form>
</body>
</html>
