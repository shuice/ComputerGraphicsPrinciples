using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Object3D
    {
        public Transform transform;

        public string name;

        public Object3D()
        {
            transform = new Transform();
            name = "";
        }

        public virtual List<Line> GetLines() { return new List<Line>(); }

        public List<Triangle> GetTriangles() { return new List<Triangle>();
            
        }
    }


    class CubeObject : Object3D
    {
        public override List<Line> GetLines()
        {
            List<Line> lines = new List<Line>();
            lines.Add(new Line(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(+0.5f, -0.5f, -0.5f), Color.Orange));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, -0.5f), new Vector3(+0.5f, -0.5f, +0.5f), Color.Orange));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, +0.5f), new Vector3(-0.5f, -0.5f, +0.5f), Color.Orange));
            lines.Add(new Line(new Vector3(-0.5f, -0.5f, +0.5f), new Vector3(-0.5f, -0.5f, -0.5f), Color.Orange));

            lines.Add(new Line(new Vector3(-0.5f, +0.5f, -0.5f), new Vector3(+0.5f, +0.5f, -0.5f), Color.Brown));
            lines.Add(new Line(new Vector3(+0.5f, +0.5f, -0.5f), new Vector3(+0.5f, +0.5f, +0.5f), Color.Brown));
            lines.Add(new Line(new Vector3(+0.5f, +0.5f, +0.5f), new Vector3(-0.5f, +0.5f, +0.5f), Color.Brown));
            lines.Add(new Line(new Vector3(-0.5f, +0.5f, +0.5f), new Vector3(-0.5f, +0.5f, -0.5f), Color.Brown));

            lines.Add(new Line(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(-0.5f, +0.5f, -0.5f), Color.Black));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, -0.5f), new Vector3(+0.5f, +0.5f, -0.5f), Color.Black));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, +0.5f), new Vector3(+0.5f, +0.5f, +0.5f), Color.Black));
            lines.Add(new Line(new Vector3(-0.5f, -0.5f, +0.5f), new Vector3(-0.5f, +0.5f, +0.5f), Color.Black));

            return lines;
        }
    }

    class CoordinateObject : Object3D
    {
        public override List<Line> GetLines()
        {
            List<Line> lines = new List<Line>();
            lines.Add(new Line(new Vector3(0, 0, 0), new Vector3(5, 0, 0), Color.Red));
            lines.Add(new Line(new Vector3(0, 0, 0), new Vector3(0, 5, 0), Color.Green));
            lines.Add(new Line(new Vector3(0, 0, 0), new Vector3(0, 0, 5), Color.Blue));
            return lines;
        }
    }
}
