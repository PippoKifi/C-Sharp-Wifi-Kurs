<html>
<head>
    <title>WebErstes</title>
    <%@ page language="C#" %>
    <script runat="server">
    void page_load()
    {
        int x, y, z;
        x = 5;
        y = 12;
        z = x + y;
        ergebnis.InnerText = "Ergebnis: " + z;
    }
    </script>
</head>
<body>
    <p id="ergebnis" runat="server"></p>
</body>
</html>
