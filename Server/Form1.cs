using laba1_oop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class frmMainServer : Form
    {
        private static Figure figure;
        public static Graphics graphicsServer;

        public static Bitmap bitmap;

        // private Pen pen;
        private bool paint;
        private bool isFirstSet = false;

        private float width;

        private Point startPoint;   // coordinates of the starting point
        private Point endPoint;     // coordinates of the endpoint

        private ColorDialog cd = new ColorDialog();
        private Color color;

        private static FigureMethod DrawingMethod = new FigureMethod();

       // private byte[] buffer;

        public frmMainServer()
        {
            InitializeComponent();

           // btColor.BackColor = Color.Black;
            color = Color.Black;
            width = 1;
            paint = false;

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            graphicsServer = Graphics.FromImage(bitmap);
            graphicsServer.Clear(Color.White);

          //  DrawFigure(buffer);
        }

        // Convert a byte array to an Object
        public static Figure ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = (Figure)binForm.Deserialize(memStream);
                return obj;
            }
        }

        public static void DrawFigure(byte[] buffer)
        {
            //figure = (Figure)ByteArrayToObject(buffer);
            figure = ByteArrayToObject(buffer);

            DrawingMethod.figure = figure;
            DrawingMethod.Drawing(graphicsServer, figure);

            pictureBox1.Refresh();

            // TODO : Check last byte of buffer 
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            startForm.Show();
        }
    }
}
