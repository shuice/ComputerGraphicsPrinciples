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

        

        public List<Line> GetLines() { return new List<Line>(); }

        public List<Triangle> GetTriangles() { return new List<Triangle>();
            
        }
    }


    class CubeObject : Object
    {
        List<Line> GetLines()
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
}
