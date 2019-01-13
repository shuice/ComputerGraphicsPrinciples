using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    // 包含alpha通道
    class MemoryBitmap
    {
        private Bitmap bitmap;
        private BitmapData bitmapData;
        public MemoryBitmap(Int32 width, Int32 height)
        {
            bitmap = new Bitmap(width, height);
            Lock();
        }

        ~MemoryBitmap()
        {
            //UnLock();
            bitmap.Dispose();
        }

        private void Lock()
        {
            bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
        }

        private void UnLock()
        {
            bitmap.UnlockBits(bitmapData);
        }

        public Color GetColor(Int32 x, Int32 y)
        {
            Int32 B;
            Int32 G;
            Int32 R;
            Int32 A;

            bitmap.GetPixel(x, y);
            unsafe
            {
                byte* pByte = (byte*)bitmapData.Scan0 + x * 4 + y * bitmapData.Stride;
                B = pByte[0];
                G = pByte[1];
                R = pByte[2];
                A = pByte[3];
            }
            return Color.FromArgb(A, R, G, B);
        }

        private void Swap(ref Point from, ref Point to)
        {
            Point tmp = from;
            from = to;
            to = tmp;
        }

        public void DrawLine(Point from, Point to, Color color)
        {
            if ((IsPointIn(from) == false) || (IsPointIn(to) == false))
            {
                return;
            }


            int xDistance = Math.Abs(to.X - from.X);
            int yDistance = Math.Abs(to.Y - from.Y);
            if (xDistance < yDistance)
            {
                if (from.Y > to.Y)
                {
                    Swap(ref from, ref to);
                }
                int xBegin = from.X;
                float xStep = (xDistance * 1.0f / yDistance) * ((to.X > from.X) ? 1 : -1);
                int yBegin = from.Y;
                int yEnd = to.Y;
                int pointCount = yEnd - yBegin + 1;

                for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
                {
                    int x = (int)(Math.Round(xBegin + pointIndex * xStep));
                    int y = yBegin + pointIndex;
                    SetColor(x, y, color);
                }
            }
            else
            {
                if (from.X > to.X)
                {
                    Swap(ref from, ref to);
                }
                int yBegin = from.Y;
                float yStep = (yDistance * 1.0f / xDistance) * ((to.Y > from.Y) ? 1 : -1);
                int xBegin = from.X;
                int xEnd = to.X;
                int pointCount = xEnd - xBegin + 1;

                for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
                {
                    int x = xBegin + pointIndex;
                    int y = (int)(Math.Round(yBegin + pointIndex * yStep));
                    SetColor(x, y, color);
                }
            }
        }

        private bool IsPointIn(Point pt)
        {
            if ((pt.X < 0)
                || (pt.X >= bitmap.Width)
                || (pt.Y < 0)
                || (pt.Y >= bitmap.Height))
            {
                return false;
            }
            return true;
        }

        public void SetColor(Int32 x, Int32 y, Color color)
        {
            if (IsPointIn(new Point(x, y)) == false)
            {
                return;
            }
            unsafe
            {
                byte* pByte = (byte*)bitmapData.Scan0 + x * 4 + y * bitmapData.Stride;
                pByte[0] = color.B;
                pByte[1] = color.G;
                pByte[2] = color.R;
                pByte[3] = color.A;
            }
        }

        public Bitmap GetBitmapCopy()
        {
            UnLock();
            Bitmap copyedBitmap = new Bitmap(bitmap);
            Lock();
            copyedBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return copyedBitmap;
        }
    }
}
