<html>
<head>
    <title>WebFormatierung</title>
    <%@ page language="C#" %>
    <script runat="server">
    void page_load()
    {
        int x, y, z;
        x = 5;
        y = 12;
        z = x + y;
        ergebnis.Text = "Ergebnis: " + z ;
        ergebnis.Font.Size = 24;
        ergebnis.Font.Bold = true;
        ergebnis.Font.Underline = true;
    }
    </script>
</head>

<body>
    <asp:Label id="ergebnis" runat="server" />
</body>
</html>
