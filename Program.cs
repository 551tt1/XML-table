using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace XML_sheet1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("C://Drugs.xml");
            XmlElement xRoot = xdoc.DocumentElement;

            XmlElement drugElement = xdoc.CreateElement("Drugs");

            XmlAttribute drugName = xdoc.CreateAttribute("Name");
            XmlAttribute drugInfluence = xdoc.CreateAttribute("Influence");
            XmlAttribute drugDuration = xdoc.CreateAttribute("DurationOfExposure");
            XmlAttribute drugAddictive = xdoc.CreateAttribute("Addictive");




            // Скума (ориг. Skooma)
            XmlText scoomaName = xdoc.CreateTextNode("Skooma");
            XmlText scoomaInfluence = xdoc.CreateTextNode("Strong");
            XmlText scoomaDuration = xdoc.CreateTextNode("Week");
            XmlText scoomaAddictive = xdoc.CreateTextNode("Strong");

            // Psycho - Психо
            XmlText psychoName = xdoc.CreateTextNode("Psycho");
            XmlText psychoInfluence = xdoc.CreateTextNode("+25% damage");
            XmlText psychoDuration = xdoc.CreateTextNode("4 minutes");
            XmlText psychoAddictive = xdoc.CreateTextNode("10% chanсe");

            // Винт - Jet 
            XmlText jetName = xdoc.CreateTextNode("Jet");
            XmlText jetInfluence = xdoc.CreateTextNode("+30 Max Action Point");
            XmlText jetDuration = xdoc.CreateTextNode("4 minutes");
            XmlText jetAddictive = xdoc.CreateTextNode("20% chance");

            // Ментаты - Mentats
            XmlText mentatsName = xdoc.CreateTextNode("Mentats");
            XmlText mentatsInfluence = xdoc.CreateTextNode("+2 Intelligence; +2 Perception; +1 Charisma");
            XmlText mentatsDuration = xdoc.CreateTextNode("A day");
            XmlText mentatsAddictive = xdoc.CreateTextNode("15% chance");

            // Мед-X (англ. Med-X)
            XmlText medXName = xdoc.CreateTextNode("Med-X");
            XmlText medXInfluence = xdoc.CreateTextNode("+25 damage resistance");
            XmlText medXDuration = xdoc.CreateTextNode("4 minutes");
            XmlText medXAddictive = xdoc.CreateTextNode("10% chance, + 30 UMON for 30h");

            // Фисштех (ориг. Fisstech)
            XmlText fisstechName = xdoc.CreateTextNode("Fisstech");
            XmlText fisstechInfluence = xdoc.CreateTextNode("Еmotional uplift, euphoria, increased mental and physical activity");
            XmlText fisstechDuration = xdoc.CreateTextNode("8 hours");
            XmlText fisstechAddictive = xdoc.CreateTextNode("Strong");




            drugName.AppendChild(scoomaName);
            drugInfluence.AppendChild(scoomaInfluence);
            drugDuration.AppendChild(scoomaDuration);
            drugAddictive.AppendChild(scoomaAddictive);

            drugElement.Attributes.Append(drugName);
            drugElement.Attributes.Append(drugInfluence);
            drugElement.Attributes.Append(drugDuration);
            drugElement.Attributes.Append(drugAddictive);

            xRoot.AppendChild(drugElement);
            xdoc.Save("C://Drugs.xml");
        }
    }
}
