using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace LINQBeamTransform
{
    class Program
    {

        
        static void Main()
        {
            

            XDocument result = new XDocument(                
                new XElement("table", new XAttribute("border", 1),
                new XElement("thead",
                new XElement("tr",
                new XElement("th", "Id"),
                new XElement("th", "Profile"),
                new XElement("th", "Primer"),
                new XElement("th", "Length"))),
                new XElement("tbody",
                from steelmember in
                    XDocument.Load(@"C:\Users\brung\Desktop\Programming\Software Development\C#\C#\Linq XML\My Projects\LINQBeamTransform\LINQBeamTransform\Steel.xml").Descendants("SteelMember")
                select new XElement("tr",
                new XElement("td", steelmember.Attribute("Id").Value),
                new XElement("td", steelmember.Element("Profile").Value),
                new XElement("td", steelmember.Element("Primer").Value),
                new XElement("td", steelmember.Element("Length").Value)))));

            result.Save(@"C:\Users\brung\Desktop\Programming\Software Development\C#\C#\Linq XML\My Projects\LINQBeamTransform\LINQBeamTransform\Steel.htm");
        }
    }
}
