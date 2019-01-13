using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Vector3
    {
        public float x;
        public float y;
        public float z;
            
        public Vector3()
        {
            this.x = 0.0f;
            this.y = 0.0f;
            this.z = 0.0f;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        float Distance(Vector3 vector3)
        {
            return 1.0f;
        }
        static Vector3 Zero()
        {
            return new Vector3(0, 0, 0);
        }

        public override string ToString()
        {
            return String.Format("[x={0}, y={1}, z={2}]", x, y, z);
        }
    }

    class Vector4 : Vector3
    {
        public float w;
        public Vector4(Vector3 v, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }

        public Vector4(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
