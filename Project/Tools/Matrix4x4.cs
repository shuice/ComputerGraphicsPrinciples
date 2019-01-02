using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    
    class Matrix4x4
    {
        public const float Deg2Rad = 0.0174532924F;
        public float[] data;   // 行优先
        public Matrix4x4()
        {
            data = new float[16];
            for (int i = 0; i < 16; i ++)
            {
                data[i] = 0.0f;
            }
        }


        public float Get(int row, int col)
        {
            return data[row * 4 + col];
        }
        public void Set(int row, int col, float value)
        {
            data[row * 4 + col] = value;
        }

        public static Matrix4x4 CrossProduct (Matrix4x4 lft, Matrix4x4 rht)
        {
            Matrix4x4 matrix4x4 = new Matrix4x4();
            for (int row = 0; row < 4; row ++)
            {
                for (int col = 0; col < 4; col ++)
                {
                    float dot = Dot(ref lft, ref rht, row, col);
                    matrix4x4.Set(row, col, dot);
                }
            }
            return matrix4x4;
        }

        public static Vector4 CrossProduct(Matrix4x4 lft, Vector4 v)
        {
            Vector4 vector = new Vector4();
            vector.x = lft.Get(0, 0) * v.x + lft.Get(0, 1) * v.y + lft.Get(0, 2) * v.z + lft.Get(0, 3) * v.w;
            vector.y = lft.Get(1, 0) * v.x + lft.Get(1, 1) * v.y + lft.Get(1, 2) * v.z + lft.Get(1, 3) * v.w;
            vector.z = lft.Get(2, 0) * v.x + lft.Get(2, 1) * v.y + lft.Get(2, 2) * v.z + lft.Get(2, 3) * v.w;
            vector.w = lft.Get(3, 0) * v.x + lft.Get(3, 1) * v.y + lft.Get(3, 2) * v.z + lft.Get(3, 3) * v.w;
            return vector;
        }

        public static Matrix4x4 Normalized()
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.Set(0, 0, 1);
            matrix.Set(1, 1, 1);
            matrix.Set(2, 2, 1);
            matrix.Set(3, 3, 1);
            return matrix;
        }



        private static float Dot(ref Matrix4x4 lft, ref Matrix4x4 rht, int row, int col)
        {
            Matrix4x4 matrix4x4 = new Matrix4x4();
            float result = 0.0f;
            for (int i = 0; i < 4; i++)
            {
                result += lft.Get(row, i) * rht.Get(i, col);
            }
            return result;
        }

        public static Matrix4x4 RotateZ(float alpha)
        {
            alpha = Deg2Rad * alpha;
            Matrix4x4 matrix = new Matrix4x4();
            matrix.Set(0, 0, (float)Math.Cos(alpha));
            matrix.Set(0, 1, (float)-Math.Sin(alpha));
            matrix.Set(1, 0, (float)Math.Sin(alpha));
            matrix.Set(1, 1, (float)Math.Cos(alpha));
            matrix.Set(2, 2, 1);
            matrix.Set(3, 3, 1);
            return matrix;
        }

        public static Matrix4x4 RotateX(float alpha)
        {
            alpha = Deg2Rad * alpha;
            Matrix4x4 matrix = new Matrix4x4();
            matrix.Set(0, 0, 1);
            matrix.Set(1, 1, (float)Math.Cos(alpha));
            matrix.Set(1, 2, (float)-Math.Sin(alpha));
            matrix.Set(2, 1, (float)Math.Sin(alpha));
            matrix.Set(2, 2, (float)Math.Cos(alpha));
            matrix.Set(3, 3, 1);
            return matrix;
        }

        public static Matrix4x4 RotateY(float alpha)
        {
            alpha = Deg2Rad * alpha;
            Matrix4x4 matrix = new Matrix4x4();
            matrix.Set(0, 0, (float)Math.Cos(alpha));
            matrix.Set(0, 2, (float)Math.Sin(alpha));
            matrix.Set(1, 1, 1);
            matrix.Set(2, 0, (float)-Math.Sin(alpha));
            matrix.Set(2, 2, (float)Math.Cos(alpha));
            matrix.Set(3, 3, 1);
            return matrix;
        }

        public static Matrix4x4 Scale(float x, float y, float z)
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.Set(0, 0, x);
            matrix.Set(1, 1, y);
            matrix.Set(2, 2, z);
            matrix.Set(3, 3, 1);
            return matrix;
        }

        public static Matrix4x4 Translation(float x, float y, float z)
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.Set(0, 0, 1);
            matrix.Set(0, 3, x);
            matrix.Set(1, 1, 1);
            matrix.Set(1, 3, y);
            matrix.Set(2, 2, 1);
            matrix.Set(2, 3, z);
            matrix.Set(3, 3, 1);
            return matrix;
        }
    }
}
