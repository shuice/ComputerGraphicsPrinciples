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

        public void DrawLine(Point from, Point to, Color color)
        {
            if ((IsPointIn(from) == false) || (IsPointIn(to) == false))
            {
                return;
            }

            UnLock();
            Graphics g = Graphics.FromImage(bitmap);
            Pen p = new Pen(color);

            g.DrawLine(p, from, to);
            Lock();
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
