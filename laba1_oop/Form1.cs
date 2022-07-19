using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Threading;
using laba1_OOP;

namespace laba1_oop
{
    public partial class Form1 : Form
    {
        private Figure figure;
        public static Graphics graphics;

        public Form2 f2;

        private About f3;

        public static Bitmap bitmap;

       // private Pen pen;
        private bool paint;

        private float width;

        private Point startPoint;   // coordinates of the starting point
        private Point endPoint;     // coordinates of the endpoint

        private ColorDialog cd = new ColorDialog();
        private Color color;

        // modified
        public static FigureMethod DrawingMethod = new FigureMethod();

        // new
        public static TcpClient client;
        public static NetworkStream stream;
        // public static byte[] buf = new byte[4];

        public IPluginGeneral p;

        public Form1()
        {
            InitializeComponent();

            btColor.BackColor = Color.Black;
            color = Color.Black;
            width = 1;
            paint = false;

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            graphics = Graphics.FromImage(bitmap);

            p = LoadPlugin.JsonLoad();
        }

        public static void DeserialServer(NetworkStream stream)
        {
            byte[] buffer1 = new byte[1] { 1 };
            stream.Write(buffer1, 0, buffer1.Length);

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            graphics = Graphics.FromImage(bitmap);

            FigureClass.DeserialMethod();
            foreach (var figureDes in FigureClass.FigureList1)
            {
                DrawingMethod.figure = figureDes;
                DrawingMethod.Drawing(graphics, figureDes);
                byte[] buffer = ObjectToByteArray(figureDes);
                stream.Write(buffer, 0, buffer.Length);
                System.Threading.Thread.Sleep(100);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // user starts drawing
            paint = true;

            // coordinates of the starting point
            startPoint.X = e.X;
            startPoint.Y = e.Y;

            // end point is equal to starting point
            endPoint.X = e.X;
            endPoint.Y = e.Y;
        }

        //new
        // Convert an object to a byte array
        public static byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                byte[] var = ms.ToArray();
                return var;
            }
        }

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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                endPoint.X = e.X;
                endPoint.Y = e.Y;

                paint = false;

                FigureClass.FigureList.Add(figure);

                //  FigureClass.DeserialMethod();
                
                figure.StartPoint = startPoint;
                figure.EndPoint = endPoint;
                DrawingMethod.figure = figure;
                DrawingMethod.Drawing(graphics, figure);

                //new
                // Sending data to server
                byte[] buffer = ObjectToByteArray(figure);
                stream.Write(buffer, 0, buffer.Length);

                pictureBox1.Refresh();
              //  FigureClass.SerialMethod();
                figure = (Figure)figure.Clone();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            width = (float)trackBar1.Value;
            if (figure != null)
            {
                // pen = new Pen(color, width);
                figure.width = width;
               // figure.color = color;
                figure.colorInt = color.ToArgb();
            }
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                btColor.BackColor = cd.Color;
                color = cd.Color;

                if (figure != null)
                {
                    //figure.Pen = new Pen(color, width);
                    figure.width = width;
                    // figure.color = color;
                    figure.colorInt = color.ToArgb();
                }
             }

        }

        private void btLine_Click(object sender, EventArgs e)
        {
            figure = new Line(color, width);
        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            figure = new Rectangle(color, width);
        }

        private void btSquare_Click(object sender, EventArgs e)
        {
            figure = new Square(color, width);
        }

        private void btInheretedTriangle_Click(object sender, EventArgs e)
        {
            figure = new InheretedTriangle(color, width);
        }

        private void btEllipse_Click(object sender, EventArgs e)
        {
            figure = new Ellipse(color, width);
        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            figure = new Circle(color, width);
        }

        public static void ClearImage()
        {
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1] { 1 };
            stream.Write(buffer, 0, buffer.Length);
            ClearAll();
        }

        private static void ClearAll()
        {
            FigureClass.FigureList.Clear();
            FigureClass.FigureList1.Clear();
            ClearImage();
            pictureBox1.Refresh();
        }

        private void LoadXml_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            var startForm = new frmStart();
            startForm.Show();
        }

        static void DrawFig(byte[] bytes) 
        {
            Figure fg = ByteArrayToObject(bytes);
            DrawingMethod.figure = fg;
            DrawingMethod.Drawing(graphics, fg);

            pictureBox1.Refresh();
            // TODO: refresh pictureBox
        }

        // new
        // Getting data from server
        public static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[2048]; // буфер для получаемых данных
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                    }
                    while (stream.DataAvailable);

                    if (bytes == 1)
                    {
                        ClearAll();
                    }
                    else
                    {
                        DrawFig(data);
                    }
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }

        // new
        public static string path;
        public static void SaveAs()
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:/Users/1/Downloads/course_work/Images";
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                // create xml filename
                path = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                string insertStr = ".xml";
                path = path.Insert(path.Length, insertStr);
                FigureClass.SerialMethod();

                fs.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you want to save changes?";
            string caption = "Save changes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            switch (result)
            {
                case System.Windows.Forms.DialogResult.No:
                    ClearImage();
                    System.Windows.Forms.Application.Exit();
                    break;
                case System.Windows.Forms.DialogResult.Yes:
                    SaveAs();
                    break;

                case System.Windows.Forms.DialogResult.Cancel:
                    break;

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new About();
            f3.Show();
        }

        public static string pathXml;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:/Users/1/Downloads/course_work/Images";
                openFileDialog.Filter = "JPeg Image|*.jpg|Gif Image|*.gif";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    pathXml = Path.GetFileNameWithoutExtension(filePath);
                    string insertStr = ".xml";
                    pathXml = pathXml.Insert(pathXml.Length, insertStr);
                    DeserialServer(stream);

                }
            }

        }

        private void packToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:/Users/1/Downloads/course_work/Images";
                    openFileDialog.Filter = "JPeg Image|*.jpg|Gif Image|*.gif";
                    openFileDialog.FilterIndex = 3;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        string fileArchive = openFileDialog.FileName;
                    }

                    string sourceFile = openFileDialog.FileName;
                    string destFile = Path.GetFileNameWithoutExtension(sourceFile);
                    string insertStr = ".gz";
                    destFile = destFile.Insert(destFile.Length, insertStr);

                    p.CompressAsync(sourceFile, destFile);
                }

            }
            catch
            {

                string message = "Exception";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }
        }

        private void unpackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:/Users/1/Downloads/course_work/laba1_oop/bin/Debug";
                    openFileDialog.Filter = "Gz archive|*.gz";   
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        string fileArchive = openFileDialog.FileName;
                    }

                    string sourceFile = openFileDialog.FileName;
                    string destFile = Path.GetFileNameWithoutExtension(sourceFile);
                    string insertStr = "1.jpg";
                    destFile = destFile.Insert(destFile.Length, insertStr);

                    p.DecompressAsync(sourceFile, destFile);

                    pathXml = Path.GetFileNameWithoutExtension(sourceFile);
                    string insertStr1 = ".xml";
                    pathXml = pathXml.Insert(pathXml.Length, insertStr1);
                    DeserialServer(stream);
                }

            }
            catch
            {
                string message = "Exception";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }

        }
    }
}
