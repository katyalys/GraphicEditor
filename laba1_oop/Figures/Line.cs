using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    [Serializable]
    public class Line : Figure
    {

        public Line(Color color, float width) : base(color, width) {
            EnumTmp = EnumType.Line;
        }
        public Line(Color color, float width, int x1, int y1, int x2, int y2) : base(color, width)
        {
            Point startPoint = new Point(x1, y1);
            Point endPoint = new Point(x2, y2);

            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Line() { }
        public override object Clone()
        {
            return new Line(Color.FromArgb(colorInt), width);
        }
    }
}
