using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Camera : Object3D
    {
        public float near;
        public float far;
        public float fov;
        public float aspect;
        public const float Deg2Rad = 0.0174532924F;

        public Matrix4x4 ViewMatrix()
        {
            Matrix4x4 normalized = Matrix4x4.Normalized();
            normalized.Set(2, 2, -1);   // 照相机坐标系是右手坐标系
            Matrix4x4  viewMatrix = Matrix4x4.CrossProduct(normalized, this.transform.InverseTransformMatrix());
            return viewMatrix;
        }

        public Matrix4x4 ProjectMatrix()
        {
            float fovDeg = Deg2Rad * fov;
            Matrix4x4 matrix = new Matrix4x4();
            float cotHalfFov = (float)(1.0f / Math.Tan(fovDeg / 2));
            matrix.Set(0, 0, cotHalfFov / aspect);
            matrix.Set(1, 1, cotHalfFov);
            matrix.Set(2, 2, -(far + near) / (far - near));
            matrix.Set(2, 3, -2 * near * far / (far - near));
            matrix.Set(3, 2, -1);
            return matrix;
        }
    }
}
