using System;
using System.IO;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdImageSelector.Title = "Choose an image";
            ofdImageSelector.Filter = "png files, jpg files(*.png, *.jpg)|*.png;*.jpg|txt files(.txt)|*.txt|All Files|*.*";

            if (ofdImageSelector.ShowDialog() == DialogResult.OK)
            {
                string path = ofdImageSelector.FileName;

                pictureBox1.Load(path);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;

            saveFileDialog1.Filter = "txt files|*.txt";
            saveFileDialog1.InitialDirectory = "C:\\";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, text);
            }
        }
    }
}