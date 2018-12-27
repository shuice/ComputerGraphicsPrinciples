using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Line
    {
        public Line(Vector3 from, Vector3 to)
        {
            this.from = from;
            this.to = to;
        }
        public Vector3 from;
        public Vector3 to;
    }
}
