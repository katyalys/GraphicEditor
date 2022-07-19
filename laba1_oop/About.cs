using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_oop
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            richTextBox1.LoadFile("C:/Users/1/Downloads/course_work/About.txt", RichTextBoxStreamType.PlainText);
        }

        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    //string path = "C:/Users/1/Downloads/course_work/About.txt";
        //    //richTextBox1.Text = File.ReadAllText(path);
        //   // richTextBox1.LoadFile("C:/Users/1/Downloads/course_work/About.txt");

        //}
    }
}
