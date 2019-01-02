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
using Object = ComputerGraphics.Tools.Object3D;

namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        private EnvBuilder envBuilder;
        private CubeObject cube;
        private Camera camera;
        private bool isInit;
        public Form1()
        {
            InitializeComponent();
            cube = new CubeObject();
            envBuilder = new EnvBuilder(cube);
            isInit = true;
            UpdateValueFromModal();
            isInit = false;
            DrawImage();
        }

        private void UpdateValueFromModal()
        {
            Object3D object3D = envBuilder.GetRootObject();
            camera = envBuilder.camera;

            Transform object3DTransfrom = object3D.transform;
            Transform cameraTransfrom = camera.transform;

            cubePosX.Text = object3DTransfrom.pos.x.ToString();
            cubePosY.Text = object3DTransfrom.pos.y.ToString();
            cubePosZ.Text = object3DTransfrom.pos.z.ToString();

            cubeRotateX.Text = object3DTransfrom.rotate.x.ToString();
            cubeRotateY.Text = object3DTransfrom.rotate.y.ToString();
            cubeRotateZ.Text = object3DTransfrom.rotate.z.ToString();

            cubeScaleX.Text = object3DTransfrom.scale.x.ToString();
            cubeScaleY.Text = object3DTransfrom.scale.y.ToString();
            cubeScaleZ.Text = object3DTransfrom.scale.z.ToString();


            cameraPosX.Text = cameraTransfrom.pos.x.ToString();
            cameraPosY.Text = cameraTransfrom.pos.y.ToString();
            cameraPosZ.Text = cameraTransfrom.pos.z.ToString();

            cameraRotateX.Text = cameraTransfrom.rotate.x.ToString();
            cameraRotateY.Text = cameraTransfrom.rotate.y.ToString();
            cameraRotateZ.Text = cameraTransfrom.rotate.z.ToString();
        }

        private void DrawImage()
        {
            if (isInit)
            {
                return;
            }
            Bitmap bitemap = envBuilder.Render(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitemap;
        }

        private float ToFloat(string s)
        {
            try
            {
                return float.Parse(s);
            }
            catch(Exception e)
            {

            }
            return 0;
            
        }
        private void cubePosX_TextChanged(object sender, EventArgs e)
        {
            cube.transform.pos.x = ToFloat(cubePosX.Text);
            DrawImage();
        }

        private void cubePosY_TextChanged(object sender, EventArgs e)
        {
            cube.transform.pos.y = ToFloat(cubePosY.Text);
            DrawImage();
        }

        private void cubePosZ_TextChanged(object sender, EventArgs e)
        {
            cube.transform.pos.z = ToFloat(cubePosZ.Text);
            DrawImage();
        }

        private void cubeRotateX_TextChanged(object sender, EventArgs e)
        {
            cube.transform.rotate.x = ToFloat(cubeRotateX.Text);
            DrawImage();
        }

        private void cubeRotateY_TextChanged(object sender, EventArgs e)
        {
            cube.transform.rotate.y = ToFloat(cubeRotateY.Text);
            DrawImage();
        }

        private void cubeRotateZ_TextChanged(object sender, EventArgs e)
        {
            cube.transform.rotate.z = ToFloat(cubeRotateZ.Text);
            DrawImage();
        }

        private void cubeScaleX_TextChanged(object sender, EventArgs e)
        {
            cube.transform.scale.x = ToFloat(cubeScaleX.Text);
            DrawImage();
        }

        private void cubeScaleY_TextChanged(object sender, EventArgs e)
        {
            cube.transform.scale.y = ToFloat(cubeScaleY.Text);
            DrawImage();
        }

        private void cubeScaleZ_TextChanged(object sender, EventArgs e)
        {
            cube.transform.scale.z = ToFloat(cubeScaleZ.Text);
            DrawImage();
        }

        private void cameraPosX_TextChanged(object sender, EventArgs e)
        {
            camera.transform.pos.x = ToFloat(cameraPosX.Text);
            DrawImage();
        }

        private void cameraPosY_TextChanged(object sender, EventArgs e)
        {
            camera.transform.pos.y = ToFloat(cameraPosY.Text);
            DrawImage();
        }

        private void cameraPosZ_TextChanged(object sender, EventArgs e)
        {
            camera.transform.pos.z = ToFloat(cameraPosZ.Text);
            DrawImage();
        }

        private void cameraRotateX_TextChanged(object sender, EventArgs e)
        {
            camera.transform.rotate.x = ToFloat(cameraRotateX.Text);
            DrawImage();
        }

        private void cameraRotateY_TextChanged(object sender, EventArgs e)
        {
            camera.transform.rotate.y = ToFloat(cameraRotateY.Text);
            DrawImage();
        }

        private void cameraRotateZ_TextChanged(object sender, EventArgs e)
        {
            camera.transform.rotate.z = ToFloat(cameraRotateZ.Text);
            DrawImage();
        }
    }
}
