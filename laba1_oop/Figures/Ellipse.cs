using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    [Serializable]
    public class Ellipse : Figure
    {

        public Ellipse(Color color, float width) : base(color, width) {
            EnumTmp = EnumType.Ellipse;
        }

        public Ellipse(Color color, float width, Point start, Point end) : base(color, width)
        {
            Point startPoint = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
            Point endPoint = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            StartPoint = startPoint;
            EndPoint = endPoint;

        }

        public Ellipse(Color color, float width, int x1, int x2, int y1, int y2) : base(color, width)
        {
            Point startPoint = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point endPoint = new Point(Math.Max(x1, x2), Math.Max(y1, y2));

            StartPoint = startPoint;
            EndPoint = endPoint;

        }

        public Ellipse() { }

        public override object Clone()
        {
            return new Ellipse(Color.FromArgb(colorInt), width);
        }
    }
}
