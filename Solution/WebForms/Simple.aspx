﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple.aspx.cs" Inherits="WebForms.Simple" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Literal ID="litLogger" EnableViewState="true" runat="server"></asp:Literal>
    <p><asp:Button runat="server" ID="btnTest" Text="Clicky" OnClick="btnTest_Click"/></p>
    </div>
    </form>
</body>
</html>
