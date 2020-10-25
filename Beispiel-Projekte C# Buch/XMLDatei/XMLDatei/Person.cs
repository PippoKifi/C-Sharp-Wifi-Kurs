using System;
using System.Xml;

namespace XMLDatei
{
    class Person
    {
        string name;
        string vorname;
        int personalnummer;
        double gehalt;
        DateTime geburtstag;

        public Person(string na, string vo, int pe, double gh, DateTime gb)
        {
            name = na;
            vorname = vo;
            personalnummer = pe;
            gehalt = gh;
            geburtstag = gb;
        }

        public void AlsXmlElementSchreiben(XmlTextWriter xw)
        {
            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", name);
            xw.WriteAttributeString("vorname", vorname);
            xw.WriteAttributeString("personalnummer", personalnummer.ToString());
            xw.WriteAttributeString("gehalt", "" + gehalt.ToString());
            xw.WriteAttributeString("geburtstag", geburtstag.ToShortDateString());
            xw.WriteEndElement();
        }

        public string ausgabe()
        {
            return name + ", " + vorname + ", " + personalnummer
                + ", " + gehalt + ", " + geburtstag.ToShortDateString();
        }
    }
}
