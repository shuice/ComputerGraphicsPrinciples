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
            UnLock();
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

        public void DrawLine(Point from, Point to)
        {
            UnLock();
            Graphics g = Graphics.FromImage(bitmap);
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, from, to);
            Lock();
        }

        public void SetColor(Int32 x, Int32 y, Color color)
        {
            if ((x < 0)
                || (x >= bitmap.Width)
                || (y < 0)
                || (y >= bitmap.Height))
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
            
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j ++)
                {
                    
                    SetColor(i, j, Color.FromArgb(255, 255, 0, 0));
                }
            }
           
            UnLock();
            Bitmap copyedBitmap = new Bitmap(bitmap);
            Lock();
            return copyedBitmap;
        }
    }
}
