using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace laba1_oop
{

    [Serializable]
    [XmlInclude(typeof(Line))]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Ellipse))]
    [XmlInclude(typeof(InheretedTriangle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Triangle))]
    public class Figure : ICloneable
    {
        public EnumType EnumTmp { get; set; }

        public virtual Point StartPoint { get; set; }

        public virtual Point EndPoint { get; set; }

        public Point[] Vertices { get; set; }

      //  public Pen Pen { get; set; }
      //  public int color { get; set; }

        public int colorInt { get; set; }
        public float width { get; set; }

        public Figure(Color color, float width)
        {
              //Pen = new Pen(color, width);
              this.colorInt = color.ToArgb();
              //this.color.ToArgb();
              this.width = width;
              EnumTmp = EnumType.TmpField;
        }

        public Figure() { }

        public virtual object Clone()
        {
            return new Figure(Color.FromArgb(colorInt), width);
        }

    }
}
