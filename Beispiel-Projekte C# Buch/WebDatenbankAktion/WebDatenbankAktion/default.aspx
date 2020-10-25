<html>
<head>
    <title>WebDatenbankAktion</title>

    <%@ page language="C#" %>
    <%@ import namespace="System.Data.OleDb" %>
    <script runat="server">
    void page_load()
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        int anzahl;
        con.ConnectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\\Temp\\firma.accdb";
        cmd.Connection = con;
        if(IsPostBack)
        {
            try
            {
                con.Open();
                cmd.CommandText =
                    "insert into personen " +
                    "(name, vorname, personalnummer, " +
                    "gehalt, geburtstag) " +
                    "values ('" +
                    txtName.Value + "', '" +
                    txtVorname.Value + "', " +
                    txtPersonalnummer.Value + ", " +
                    txtGehalt.Value.Replace(",", ".") +
                    ", '" + txtGeburtstag.Value + "')";
                // ausgabe.Text = cmd.CommandText;
                anzahl = cmd.ExecuteNonQuery();
                if(anzahl > 0)
                    ausgabe.Text =
                        "Es wurde ein Datensatz eingefügt";
            }
            catch(Exception ex)
            {
                ausgabe.Text = ex.Message;
            }
            con.Close();
        }
        cmd.CommandText = "select * from personen";
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            grid.DataSource = reader;
            DataBind();
            reader.Close();
        }
        catch(Exception ex)
        {
            ausgabe.Text = ex.Message;
        }
        con.Close();
    }
    </script>
</head>
<body>
    <p>Datenbank-Tabelle</p>
    <asp:DataGrid id="grid" runat="server" />
    <form id="Form1" runat="server">
        <p><input type="text" runat="server"
            id="txtName" /> Name</p>
        <p><input type="text" runat="server"
            id="txtVorname" /> Vorname</p>
        <p><input type="text" runat="server"
            id="txtPersonalnummer" /> Personalnummer</p>
        <p><input type="text" runat="server"
            id="txtGehalt" /> Gehalt</p>
        <p><input type="text" runat="server"
            id="txtGeburtstag" /> Geburtstag</p>
        <p><input id="Submit1" type="submit"
            runat="server" value="Senden" />
    </form>
    <p><asp:Label id="ausgabe" runat="server" /></p>
</body>
</html>
