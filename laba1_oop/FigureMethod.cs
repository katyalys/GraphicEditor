using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1_oop
{
    public class FigureMethod
    {
        public Figure figure;

        public Pen pen { get; set; }

        // объявление делегата 
        delegate int DrawingMeth(Graphics drawing);

        public void Drawing(Graphics drawing, Figure figure)
        {
            // создание переменной делегата
            DrawingMeth drawingMethLine = DrawingLine;
            DrawingMeth drawingMethRectangle = DrawingRectangle;
            DrawingMeth drawingMethSquare = DrawingSquare;
            DrawingMeth drawingMethCircle = DrawingCircle;
            DrawingMeth drawingMethEllipse = DrawingEllipse;
            DrawingMeth drawingMethTriangle = DrawingTriangle;
            Dictionary<EnumType, DrawingMeth> MethodDict = new Dictionary<EnumType, DrawingMeth>()
            {
                { EnumType.Line, drawingMethLine },
                { EnumType.Rectangle, drawingMethRectangle },
                { EnumType.Square, drawingMethSquare },
                { EnumType.Circle, drawingMethCircle },
                { EnumType.Ellipse, drawingMethEllipse },
                { EnumType.Triangle, drawingMethTriangle }
            };

            DrawingMeth dw = MethodDict[figure.EnumTmp];
            int s = dw(drawing); // вызов метода 
        }

        
        public int DrawingLine(Graphics drawing)
        {
            Color color = Color.FromArgb(figure.colorInt);
            pen = new Pen(color, figure.width);
            drawing.DrawLine(pen, figure.StartPoint.X, figure.StartPoint.Y, figure.EndPoint.X, figure.EndPoint.Y);
            return 1;
        }

        public int DrawingRectangle(Graphics drawing)
        {
            Color color = Color.FromArgb(figure.colorInt);
            pen = new Pen(color, figure.width);
            int width = Math.Max(figure.StartPoint.X, figure.EndPoint.X) - Math.Min(figure.StartPoint.X, figure.EndPoint.X);
            int height = Math.Max(figure.StartPoint.Y, figure.EndPoint.Y) - Math.Min(figure.StartPoint.Y, figure.EndPoint.Y);
            drawing.DrawRectangle(pen, Math.Min(figure.StartPoint.X, figure.EndPoint.X), Math.Min(figure.StartPoint.Y, figure.EndPoint.Y),
                                   width, height);

            return 1;
        }

       public int DrawingSquare(Graphics drawing)
       {
            // pen = new Pen(figure.color, figure.width);
            Color color = Color.FromArgb(figure.colorInt);
            pen = new Pen(color, figure.width);
            int width = Math.Max(figure.StartPoint.X, figure.EndPoint.X) - Math.Min(figure.StartPoint.X, figure.EndPoint.X);
          // int height = Math.Max(StartPoint.Y, EndPoint.Y) - Math.Min(StartPoint.Y, EndPoint.Y);

           drawing.DrawRectangle(pen, Math.Min(figure.StartPoint.X, figure.EndPoint.X), Math.Min(figure.StartPoint.Y, figure.EndPoint.Y), 
               width, width);

            return 1;
       }

        public int DrawingCircle(Graphics drawing)
        {
            Color color = Color.FromArgb(figure.colorInt);
            pen = new Pen(color, figure.width);
            int width = Math.Max(figure.StartPoint.X, figure.EndPoint.X) - Math.Min(figure.StartPoint.X, figure.EndPoint.X);
            // int height = Math.Max(StartPoint.Y, EndPoint.Y) - Math.Min(StartPoint.Y, EndPoint.Y);

            drawing.DrawEllipse(pen, Math.Min(figure.StartPoint.X, figure.EndPoint.X), Math.Max(figure.StartPoint.Y, figure.EndPoint.Y), width, width);
            return 1;
        }

        public int DrawingEllipse(Graphics drawing)
        {
            Color color = Color.FromArgb(figure.colorInt);
            pen = new Pen(color, figure.width);
            int width = Math.Max(figure.StartPoint.X, figure.EndPoint.X) - Math.Min(figure.StartPoint.X, figure.EndPoint.X);
            int height = Math.Max(figure.StartPoint.Y, figure.EndPoint.Y) - Math.Min(figure.StartPoint.Y, figure.EndPoint.Y);

            drawing.DrawEllipse(pen, Math.Min(figure.StartPoint.X, figure.EndPoint.X), Math.Max(figure.StartPoint.Y, figure.EndPoint.Y), width, height);
            return 1;
        }

        public int DrawingTriangle(Graphics drawing)
        {
            Color color = Color.FromArgb(figure.colorInt);
            pen = new Pen(color, figure.width);
            drawing.DrawPolygon(pen, figure.Vertices);
            return 1;
        }

    }
}
