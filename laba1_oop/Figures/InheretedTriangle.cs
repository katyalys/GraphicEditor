using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    [Serializable]
    public class InheretedTriangle : Triangle
    {

        public InheretedTriangle(Color color, float width) : base(color, width) {
            EnumTmp = EnumType.Triangle;
        }

        public override Point StartPoint
        {
            set
            {
                _startPoint = value;

                Point vertex1 = new Point(_startPoint.X, _startPoint.Y);
                Point vertex2 = new Point(_endPoint.X, _endPoint.Y);
                Point vertex3 = new Point(_startPoint.X, _endPoint.Y);

                Vertices = new Point[3] { vertex1, vertex2, vertex3 };

            }
            get
            {
                return _startPoint;
            }
        }

        public override Point EndPoint
        {
            set
            {
                _endPoint = value;

                Point vertex1 = new Point(_startPoint.X, _startPoint.Y);
                Point vertex2 = new Point(_endPoint.X, _endPoint.Y);
                Point vertex3 = new Point(_startPoint.X, _endPoint.Y);

                Vertices = new Point[3] { vertex1, vertex2, vertex3 };

            }
            get
            {
                return _endPoint;
            }

        }

        public InheretedTriangle(Color color, float width, Point start, Point end) : base(color, width)
        {
            StartPoint = start;
            EndPoint = end;

        }

        public InheretedTriangle(Color color, float width, int x1, int x2, int y1, int y2) : base(color, width)
        {
             StartPoint = new Point(x1, y1);
             EndPoint = new Point(x2, y2);

        }

        public InheretedTriangle() { }
        public override object Clone()
        {
            return new InheretedTriangle(Color.FromArgb(colorInt), width);
        }
    }
}
    
