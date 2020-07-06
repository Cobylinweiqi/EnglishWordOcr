using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace OcrTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();     //显示选择文件对话框
            openFileDialog1.Filter = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var imgPath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(imgPath);
                var result = GeneralBasic.GeneralBasicText(imgPath);
                txtResult.Text = result;
                //string strResult = ImageToText(imgPath);
                //if (string.IsNullOrEmpty(strResult))
                //{
                //    txtResult.Text = "无法识别";
                //}
                //else
                //{
                //    txtResult.Text = strResult;
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
