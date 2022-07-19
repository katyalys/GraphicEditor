using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace laba1_oop
{
    public class FigureClass
    {
        [XmlArray]
        public static List<Figure> FigureList = new List<Figure>();

        // Serialization
        public static void SerialMethod() {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Figure>));

            using (FileStream fs = new FileStream(Form1.path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, FigureList);
            }
        }

        [XmlArray]
        public static List<Figure> FigureList1 = new List<Figure>();

        // Deserialization
        public static void DeserialMethod()
        {
           
            using (var reader = new StreamReader(Form1.pathXml))
            {
               // XmlElement root = xmlDoc.DocumentElement
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Figure>), new XmlRootAttribute("ArrayOfFigure"));
                FigureList1 = (List<Figure>)deserializer.Deserialize(reader);
            }
          
        }
    }
 
}
