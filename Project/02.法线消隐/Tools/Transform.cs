using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Transform
    {
        public Vector3 pos;
        public Vector3 scale;
        public Vector3 rotate;

        public Transform()
        {
            pos = new Vector3();
            scale = new Vector3(1, 1, 1);
            rotate = new Vector3();
        }

        public Matrix4x4 TransformMatrix()
        {
            Matrix4x4 matrix = Matrix4x4.CrossProduct(Matrix4x4.CrossProduct(Matrix4x4.Translation(pos.x, pos.y, pos.z), RotateMatrix()), Matrix4x4.Scale(scale.x, scale.y, scale.z));
            return matrix;
        }

        public Matrix4x4 RotateMatrix()
        {
            Matrix4x4 matrix = Matrix4x4.CrossProduct(Matrix4x4.CrossProduct(Matrix4x4.RotateY(rotate.y), Matrix4x4.RotateX(rotate.x)), Matrix4x4.RotateZ(rotate.z));
            return matrix;
        }

        public Matrix4x4 InverseRotateMatrix()
        {
            Matrix4x4 matrix = Matrix4x4.CrossProduct(Matrix4x4.CrossProduct(Matrix4x4.RotateY(-rotate.y), Matrix4x4.RotateX(-rotate.x)), Matrix4x4.RotateZ(-rotate.z));
            return matrix;
        }

        public Matrix4x4 InverseTransformMatrix()
        {
            Matrix4x4 matrix = Matrix4x4.CrossProduct(Matrix4x4.CrossProduct(Matrix4x4.Scale(1 / scale.x, 1 / scale.y, 1 / scale.z), InverseRotateMatrix()), Matrix4x4.Translation(-pos.x, -pos.y, -pos.z));
            return matrix;
        }
    }
}
