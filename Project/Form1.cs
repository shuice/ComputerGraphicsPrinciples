using ComputerGraphics.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFile = SelectFile();
            if (selectedFile.Length == 0)
            {
                return;
            }


            EnvBuilder envBuilder = new EnvBuilder(selectedFile);
            Bitmap bitmap = envBuilder.Render(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;

        }

        private string SelectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json文件|*.json";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "";
        }
    }
}
