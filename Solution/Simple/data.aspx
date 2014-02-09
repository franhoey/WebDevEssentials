<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <h2>Post Data</h2>
    <div id="postdata">
        <%
            foreach (var item in Request.Form.AllKeys)
            {
                Response.Write(string.Format("{0}={1}<br/>", item, Request.Form[item]));
            }
             %>
    </div>
    <h2>QueryString Data</h2>
    <div id="querydata">
        <%
            foreach (var item in Request.QueryString.AllKeys)
            {
                Response.Write(string.Format("{0}={1}<br/>", item, Request.QueryString[item]));
            }
             %>
    </div>
</body>
</html>
