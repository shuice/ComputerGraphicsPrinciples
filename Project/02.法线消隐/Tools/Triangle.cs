using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Triangle
    {
        public Triangle(Vector3 pt0, Vector3 pt1, Vector3 pt2)
        {
            this.pt0 = pt0;
            this.pt1 = pt1;
            this.pt2 = pt2;
        }
        public Vector3 Normal()
        {
            Vector3 v1 = pt1 - pt0;
            Vector3 v2 = pt2 - pt1;
            Vector3 normal = Vector3.CrossProduct(v1, v2);
            return normal;
        }

        public bool VisiableFromCamera(Vector3 v)
        {
            Vector3 normal = Normal();
            Vector3 v1 = v - pt0;
            if (Vector3.Angle(normal, v1) < 90)
            {
                return true; 
            }
            return false;
        }
        public Vector3 pt0;
        public Vector3 pt1;
        public Vector3 pt2;
    }
}
