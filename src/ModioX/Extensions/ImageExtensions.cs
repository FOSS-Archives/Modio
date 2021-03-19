﻿using System.Drawing;

namespace ModioX.Extensions
{
    internal static class ImageExtensions
    {
        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new(width, height);
            using Graphics g = Graphics.FromImage(result);
            g.DrawImage(bmp, 0, 0, width, height);

            return result;
        }
    }
}