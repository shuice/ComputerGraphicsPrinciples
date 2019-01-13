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
        public static Vector3 Zero()
        {
            return new Vector3(0, 0, 0);
        }

        public override string ToString()
        {
            return String.Format("[x={0}, y={1}, z={2}]", x, y, z);
        }

        public static Vector3 operator - (Vector3 a, Vector3 b)
        {
            Vector3 v = new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
            return v;
        }

        public void Normalize()
        {
            float magSq = x * x + y * y + z * z;
            if (magSq > 0.0f)
            {
                float oneOverMag = (float)(1.0f / Math.Sqrt(magSq));
                x *= oneOverMag;
                y *= oneOverMag;
                z *= oneOverMag;
            }
        }

        public static Vector3 CrossProduct(Vector3 a, Vector3 b)
        {
            Vector3 v = new Vector3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
            return v;
        }

        public static float Dot (Vector3 a, Vector3 b)
        {
            float r = a.x * b.x + a.y * b.y + a.z * b.z;
            return r;
         }
        public static float Angle(Vector3 a, Vector3 b)
        {
            a.Normalize();
            b.Normalize();

            float temp = Vector3.Dot(a, b);
            // 1和-1时为0和180°
            if (Math.Abs(Math.Abs(temp) - 1) < float.Epsilon)
            {
                return temp > 0 ? 0 : 180;
            }
            float angle = (float)Math.Acos(temp);
            angle *= (float)(180 / Math.PI);
            return angle;
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
