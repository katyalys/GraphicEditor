using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace laba1_oop
{
    public partial class Form2 : Form
    {
        public Form2 f2;

        DataSet ds = new DataSet();

        public Form2()
        {
            InitializeComponent();

            //dataGridView1.DataSource = FigureClass.FigureList;
            try
            {
                int i = 0;
                using (XmlReader xmlFileToRead = XmlReader.Create("figures.xml", new XmlReaderSettings()))
                {
                    ds = new DataSet();
                    ds.ReadXml(xmlFileToRead);
                    dataGridView1.DataSource = ds.Tables[i];
                    xmlFileToRead.Close();
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SaveXml_Click(object sender, EventArgs e)
        {
            try
            {
                using (XmlWriter xmlFileToWrite = XmlWriter.Create("figures.xml", new XmlWriterSettings()))
                {
                    ds.WriteXml(xmlFileToWrite);
                    xmlFileToWrite.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
