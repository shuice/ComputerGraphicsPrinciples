using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Object
    {
        public Transform transform;

        public string name;

        public Object()
        {
            transform = new Transform();
            name = "";
        }

        public virtual List<Line> GetLines() { return new List<Line>(); }

        public List<Triangle> GetTriangles() { return new List<Triangle>();
            
        }
    }


    class CubeObject : Object
    {
        public override List<Line> GetLines()
        {
            List<Line> lines = new List<Line>();
            lines.Add(new Line(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(+0.5f, -0.5f, -0.5f)));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, -0.5f), new Vector3(+0.5f, -0.5f, +0.5f)));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, +0.5f), new Vector3(-0.5f, -0.5f, +0.5f)));
            lines.Add(new Line(new Vector3(-0.5f, -0.5f, +0.5f), new Vector3(-0.5f, -0.5f, -0.5f)));

            lines.Add(new Line(new Vector3(-0.5f, +0.5f, -0.5f), new Vector3(+0.5f, +0.5f, -0.5f)));
            lines.Add(new Line(new Vector3(+0.5f, +0.5f, -0.5f), new Vector3(+0.5f, +0.5f, +0.5f)));
            lines.Add(new Line(new Vector3(+0.5f, +0.5f, +0.5f), new Vector3(-0.5f, +0.5f, +0.5f)));
            lines.Add(new Line(new Vector3(-0.5f, +0.5f, +0.5f), new Vector3(-0.5f, +0.5f, -0.5f)));

            lines.Add(new Line(new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(-0.5f, +0.5f, -0.5f)));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, -0.5f), new Vector3(+0.5f, +0.5f, -0.5f)));
            lines.Add(new Line(new Vector3(+0.5f, -0.5f, +0.5f), new Vector3(+0.5f, +0.5f, +0.5f)));
            lines.Add(new Line(new Vector3(-0.5f, -0.5f, +0.5f), new Vector3(-0.5f, +0.5f, +0.5f)));

            return lines;
        }
    }

    class CoordinateObject : Object
    {
        public override List<Line> GetLines()
        {
            List<Line> lines = new List<Line>();
            lines.Add(new Line(new Vector3(0, 0, 0), new Vector3(10, 0, 0)));
            lines.Add(new Line(new Vector3(0, 0, 0), new Vector3(0, 10, 0)));
            lines.Add(new Line(new Vector3(0, 0, 0), new Vector3(0, 0, 10)));
            return lines;
        }
    }
}
