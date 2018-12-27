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

        public EnvBuilder(string projectJson)
        {
            objectTree = ParseFile(projectJson);
        }

        private void TreeVisitor(Object ob)
        {
            Draw(ob);
        }

        private void Draw(Object ob)
        {
            List<Line> lines = ob.GetLines();
            foreach(Line line in lines)
            {
                DrawLine(line);
            }
        }

        private void DrawLine(Line line)
        {

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
            Draw(objectTree.data);
            return memoryBitmap.GetBitmapCopy();
        }

        private void BuildVP()
        {

        }

        private NTree<Object> ParseFile(string projectJson)
        {
            NTree<Object> objectTree = new NTree<Object>(new CubeObject());
            return objectTree;
        }
    }
}
