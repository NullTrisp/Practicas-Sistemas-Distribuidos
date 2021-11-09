using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyServer
{
    class XMLConverter
    {
        public static string EuroToDollar = "euro-dollar";
        public static string DollarToEuro = "dollar-euro";
        public readonly string exchange;
        public readonly decimal value;

        public XMLConverter(string exchange, decimal value)
        {
            this.exchange = exchange;
            this.value = value;
        }

        public static XMLConverter ReadXml(string data)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);
            var nodeUnits = doc.SelectSingleNode("//units");
            var fromUnits = doc.SelectSingleNode("//from");
            var toUnits = doc.SelectSingleNode("//to");

            return new XMLConverter(String.Concat(fromUnits.InnerText + "-" + toUnits.InnerText), Convert.ToDecimal(nodeUnits.InnerText));
        }

        public static string CreateXmlResponse(decimal value, string currency)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode responseNode = doc.CreateElement("ConvertResponse");
            doc.AppendChild(responseNode);
            XmlNode unitsNode = doc.CreateElement("currency");
            unitsNode.InnerText = currency;
            responseNode.AppendChild(unitsNode);
            XmlNode toNode = doc.CreateElement("value");
            toNode.InnerText = value.ToString();
            responseNode.AppendChild(toNode);
            return doc.InnerXml;
        }

        public static string CreateXmlErrorResponse(string msg)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);
            XmlNode responseNode = doc.CreateElement("ConvertResponse");
            responseNode.InnerText = msg;
            doc.AppendChild(responseNode);
            return doc.InnerXml;
        }
    }
}
