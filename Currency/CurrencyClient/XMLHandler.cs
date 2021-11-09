using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyClient
{
    class XMLHandler
    {
        public readonly decimal value;
        public readonly string currency;

        public XMLHandler(decimal value, string currency)
        {
            this.value = value;
            this.currency = currency;
        }
        public static string CreateXmlRequest(decimal value, string from, string to)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode responseNode = doc.CreateElement("ConvertResponse");
            doc.AppendChild(responseNode);

            XmlNode fromNode = doc.CreateElement("from");
            fromNode.InnerText = from;
            responseNode.AppendChild(fromNode);

            XmlNode toNode = doc.CreateElement("to");
            toNode.InnerText = to;
            responseNode.AppendChild(toNode);

            XmlNode unitsNode = doc.CreateElement("units");
            unitsNode.InnerText = value.ToString();
            responseNode.AppendChild(unitsNode);

            return doc.InnerXml;
        }

        public static XMLHandler GetResponse(string data)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);
            return new XMLHandler(Convert.ToDecimal(doc.SelectSingleNode("//value").InnerText), doc.SelectSingleNode("//currency").InnerText);
        }
    }
}
