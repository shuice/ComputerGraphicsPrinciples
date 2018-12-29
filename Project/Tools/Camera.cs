using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Camera : Object
    {
        public float near;
        public float far;
        public float fov;
        public float aspect;

        public Matrix4x4 ViewMatrix()
        {
            return transform.TransformMatrix();
        }

        public Matrix4x4 ProjectMatrix()
        {
            Matrix4x4 matrix = new Matrix4x4();
            float cotHalfFov = (float)(1.0f / Math.Tan(fov / 2));
            matrix.Set(0, 0, cotHalfFov / aspect);
            matrix.Set(1, 1, cotHalfFov);
            matrix.Set(2, 2, -(far + near) / (far - near));
            matrix.Set(2, 3, -2 * near * far / (far - near));
            matrix.Set(3, 2, -1);
            return matrix;
        }
    }
}
