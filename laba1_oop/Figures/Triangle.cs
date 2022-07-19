using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    [Serializable]
    public class Triangle : Figure
    {
        public Triangle(Color color, float width) : base(color, width) {}

        protected Point _startPoint;
        protected Point _endPoint;

        public Triangle() { }

        public override object Clone()
        {
            return new Triangle(Color.FromArgb(colorInt), width);
        }
    }
}
