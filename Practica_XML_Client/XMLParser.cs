using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practica_XML_Client
{
    class XMLParser
    {
        public readonly string Unit;
        public readonly decimal Value;

        public XMLParser(string unit, decimal value)
        {
            this.Unit = unit;
            this.Value = value;
        }

        public static XMLParser ReadXml(string data)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);
            var nodeUnits = doc.SelectSingleNode("//units");
            var toUnits = doc.SelectSingleNode("//to");

            return new XMLParser(nodeUnits.InnerText, Convert.ToDecimal(toUnits.InnerText));
        }

        public static string CreateXml(string from, string to, decimal value)
        {
            return $"<?xml version='1.0' encoding='utf-8' ?> <ConvertRequest><from>{from}</from><to>{to}</to><units>{value}</units></ConvertRequest>";
        }
    }
}
