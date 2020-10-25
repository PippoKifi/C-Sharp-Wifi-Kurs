<html>
<head>
    <title>WebFormular</title>
    <%@ page language="C#" %>
    <script runat="server">
    void page_load()
    {
        double z1, z2, z;

        if(IsPostBack)
        {
            try
            {
                z1 = Convert.ToDouble(zahl1.Value);
            }
            catch
            {
                z1 = 0;
            }

            try
            {
                z2 = Convert.ToDouble(zahl2.Value);
            }
            catch
            {
                z2 = 0;
            }

            z = z1 + z2;
            ergebnis.Text = "Ergebnis: " + z;
        }
    }
    </script>
</head>

<body>
    <p>Addieren</p>
    <form id="Form1" runat="server">
        <p><input runat="server" id="zahl1" /> Zahl 1</p>
        <p><input runat="server" id="zahl2" /> Zahl 2</p>
        <p><input id="Submit1" runat="server"
            type="submit" value="Senden" /></p>
    </form>
    <p><asp:Label id="ergebnis" runat="server" /></p>
</body>
</html>
