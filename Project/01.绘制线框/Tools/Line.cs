using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphics.Tools
{
    class Line
    {
        public Line(Vector3 from, Vector3 to)
        {
            this.from = from;
            this.to = to;
            this.color = Color.Black;
        }
        public Line(Vector3 from, Vector3 to, Color color)
        {
            this.from = from;
            this.to = to;
            this.color = color;
        }
        public Color color;
        public Vector3 from;
        public Vector3 to;
    }
}
