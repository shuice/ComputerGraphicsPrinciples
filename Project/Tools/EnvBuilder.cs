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
        private NTree<Object> objectTree;
        private Int32 width;
        private Int32 height;
        private MemoryBitmap memoryBitmap;
        private Matrix4x4 viewMatrix;
        private Matrix4x4 projectionMatrix;
        private Camera camera;

        public EnvBuilder(string projectJson)
        {
            objectTree = ParseFile(projectJson);
            InitCamera();
        }

        private void TreeVisitor(Object ob)
        {
            Draw(ob);
        }

        private void Draw(Object ob)
        {
            Matrix4x4 modalMatrix = ob.transform.TransformMatrix();
            Matrix4x4 mvp = projectionMatrix * viewMatrix * modalMatrix;
            List<Line> lines = ob.GetLines();
            foreach(Line line in lines)
            {
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
            Vector4 from    = mvp * new Vector4(line.from,  1);
            Vector4 to      = mvp * new Vector4(line.to,    1);

            Point screenFrom = ProjectToScreen(from);
            Point screenTo   = ProjectToScreen(to);

            System.Console.WriteLine(String.Format("lf{0}, lt{1}, vf{2}, vt{3}, sf{4}, st{5}", line.from, line.to, from, to, screenFrom, screenTo));

            DrawLineOnScreen(screenFrom, screenTo);
        }

        private void DrawLineOnScreen(Point screenFrom, Point screenTo)
        {
            memoryBitmap.DrawLine(screenFrom, screenTo);
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

        private NTree<Object> ParseFile(string projectJson)
        {
            Object cube = new CubeObject();
            cube.transform.scale = new Vector3(4, 4, 2);
            NTree<Object> objectTree = new NTree<Object>(cube);
            return objectTree;
        }

        private void InitCamera()
        {
            camera = new Camera
            {
                fov = 60,
                near = 2,
                far = 100,
                aspect = 1.33f
            };
            camera.transform.pos = new Vector3(4, 4, -4);
            camera.transform.rotate = new Vector3(30, -45, 0);
        }
    }
}
