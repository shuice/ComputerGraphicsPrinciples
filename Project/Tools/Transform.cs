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
            Matrix4x4 matrix = Matrix4x4.Translation(pos.x, pos.y, pos.z)
                                * RotateMatrix()
                                * Matrix4x4.Scale(scale.x, scale.y, scale.z);
            return matrix;
        }

        private Matrix4x4 RotateMatrix()
        {
            Matrix4x4 matrix = Matrix4x4.RotateZ(rotate.z)
                                * Matrix4x4.RotateX(rotate.z)
                                * Matrix4x4.RotateY(rotate.y);
            return matrix;
        }
    }
}
