using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class EnvBuilder
    {
        private NTree<Object3D> objectTree;
        private Int32 width;
        private Int32 height;
        private MemoryBitmap memoryBitmap;
        private Matrix4x4 viewMatrix;
        private Matrix4x4 projectionMatrix;
        public Camera camera;
        public Object3D GetRootObject()
        {
            return objectTree.data;
        }

        public EnvBuilder(string projectJson)
        {
            objectTree = ParseFile(projectJson);
            InitCamera();
        }

        public EnvBuilder(Object3D ob)
        {
            objectTree = new NTree<Object3D>(ob);
            InitCamera();
        }

        private void TreeVisitor(Object3D ob)
        {
            Draw(ob);
        }

        private void Test(Matrix4x4 modalMatrix, Vector3 modal)
        {
            Vector4 r1 = Matrix4x4.CrossProduct(modalMatrix, new Vector4(modal, 1));
            Vector4 r2 = Matrix4x4.CrossProduct(viewMatrix, r1);
            Vector4 r3 = Matrix4x4.CrossProduct(projectionMatrix, r2);
            System.Console.WriteLine(String.Format("{0}{1}", r1, r2));
        }

        private void Draw(Object3D ob)
        {
            Matrix4x4 modalMatrix = ob.transform.TransformMatrix();
            Matrix4x4 mvp = Matrix4x4.CrossProduct(Matrix4x4.CrossProduct(projectionMatrix, viewMatrix), modalMatrix);
            List<Line> lines = ob.GetLines();
            foreach(Line line in lines)
            {
                Test(modalMatrix, line.from);
                Test(modalMatrix, line.to);

                DrawLine(line, ref mvp);
            }
        }

        private Point ProjectToScreen(Vector4 vector)
        {
            Point pt = new Point();
            pt.X = (int)((vector.x * width) / (2 * vector.w) + width / 2);
            pt.Y = (int)((vector.y * height) / (2 * vector.w) + height / 2);
            return pt;
        }

        private void DrawLine(Line line, ref Matrix4x4 mvp)
        {
            Vector4 from    = Matrix4x4.CrossProduct(mvp, new Vector4(line.from,  1));
            Vector4 to      = Matrix4x4.CrossProduct(mvp, new Vector4(line.to,    1));

            Point screenFrom = ProjectToScreen(from);
            Point screenTo   = ProjectToScreen(to);

            System.Console.WriteLine(String.Format("lf{0}, lt{1}, vf{2}, vt{3}, sf{4}, st{5}", line.from, line.to, from, to, screenFrom, screenTo));

            DrawLineOnScreen(screenFrom, screenTo, line.color);
        }

        private void DrawLineOnScreen(Point screenFrom, Point screenTo, Color color)
        {
            memoryBitmap.DrawLine(screenFrom, screenTo, color);
        }

        public Bitmap Render(Int32 width, Int32 height)
        {
            this.width = width;
            this.height = height;

            BuildVP();

            memoryBitmap = new MemoryBitmap(width, height);
            //IEnumerator<NTree<Object>> c = objectTree.GetNodes(objectTree);
            //foreach (Object ob in c)
            //{
            //    Draw(ob);
            //}
            Draw(new CoordinateObject());
            Draw(objectTree.data);
            
            return memoryBitmap.GetBitmapCopy();
        }

        private void BuildVP()
        {
            viewMatrix = camera.ViewMatrix();
            projectionMatrix = camera.ProjectMatrix();
        }

        private NTree<Object3D> ParseFile(string projectJson)
        {
            Object3D cube = new CubeObject();
            cube.transform.scale = new Vector3(4, 4, 4);
            NTree<Object3D> objectTree = new NTree<Object3D>(cube);
            return objectTree;
        }

        private void InitCamera()
        {
            camera = new Camera
            {
                fov = 60,
                near = 0.4f,
                far = 100,
                aspect = 1.33f
            };
            camera.transform.pos = new Vector3(8, 8, -40);
            //camera.transform.rotate = new Vector3(20, -60, 0);
        }
    }
}
