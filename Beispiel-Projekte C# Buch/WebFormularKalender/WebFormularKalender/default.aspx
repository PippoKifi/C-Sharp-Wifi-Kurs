<html>
<head>
    <title>WebFormularKalender</title>
    <%@ page language="C#" %>
    <script runat="server">
    void auswahl(object sender, EventArgs e)
    {
        DateTime dt = new DateTime();
        dt = kalender.SelectedDate;
        ausgabe.Text =
            kalender.SelectedDate.
            ToShortDateString();
    }
    </script>
</head>

<body>
    Kalender:
    <form id="Form1" runat="server">
        <asp:Calendar id="kalender" runat="server"
            OnSelectionChanged="auswahl">
            <TodayDayStyle BackColor="Red"
                ForeColor="Yellow"></TodayDayStyle>
            <WeekendDayStyle BackColor="Yellow"
                ForeColor="Red"></WeekendDayStyle>
        </asp:Calendar>
    </form>
    <p><asp:Label id="ausgabe" runat="server" /></p>
</body>
</html>
