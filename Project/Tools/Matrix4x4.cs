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
        public float[] data;   // 行优先
        public Matrix4x4()
        {
            data = new float[16];
        }


        float Get(int row, int col)
        {
            return data[row * 4 + col];
        }
        void Set(int row, int col, float value)
        {
            data[row * 4 + col] = value;
        }

        public static Matrix4x4 operator * (Matrix4x4 lft, Matrix4x4 rht)
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
    }
}
