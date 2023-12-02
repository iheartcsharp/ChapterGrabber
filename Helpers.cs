﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace JarrettVance.ChapterTools
{
    public static class Helpers
    {

        public static string RemoveSpecialCharacters(this string str)
        {
            //remove invalid file name chars
            str = new string(str.ToCharArray().Where(c => !System.IO.Path.GetInvalidFileNameChars().Contains(c)).ToArray());

            //remove url special chars ;/?:@&=+$,()|\^[]'<>#%"
            str = new string(str.ToCharArray().Where(c => !";/?:@&=+$,()|\\^[]'<>#%\"".Contains(c)).ToArray());

            //normalize and remove non-spacing marks
            //TODO: is this really necessary?
            str = str.Normalize(NormalizationForm.FormD);
            str = new string(str.ToCharArray().Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray());

            //WCF doesn't support periods and it may throw off IIS6 or other extension mime type issues
            str = str.Replace(".", string.Empty);
            return str;
        }
        public static string RemoveNumbers(this string str)
        {
            var chars = str.ToCharArray()
                .Where(x => !char.IsDigit(x));
            return new string(chars.ToArray());
        }


        public static void FillRoundedRectangle(Graphics graphics, Rectangle rectangle, Brush brush, int radius)
        {
            if (graphics == null)
            {
                throw new ArgumentNullException("graphics");
            }

            SmoothingMode mode = graphics.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = RoundedRectangle(rectangle, radius))
            {
                graphics.FillPath(brush, path);
            }
            graphics.SmoothingMode = mode;
        }

        public static GraphicsPath RoundedRectangle(Rectangle r, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddLine(r.Left + d, r.Top, r.Right - d, r.Top);
            path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Top, r.Right, r.Top + d), -90, 90);
            path.AddLine(r.Right, r.Top + d, r.Right, r.Bottom - d);
            path.AddArc(Rectangle.FromLTRB(r.Right - d, r.Bottom - d, r.Right, r.Bottom), 0, 90);
            path.AddLine(r.Right - d, r.Bottom, r.Left + d, r.Bottom);
            path.AddArc(Rectangle.FromLTRB(r.Left, r.Bottom - d, r.Left + d, r.Bottom), 90, 90);
            path.AddLine(r.Left, r.Bottom - d, r.Left, r.Top + d);
            path.AddArc(Rectangle.FromLTRB(r.Left, r.Top, r.Left + d, r.Top + d), 180, 90);
            path.CloseFigure();
            return path;
        }
    }



    public abstract class RoundedRectangle
    {
        public enum RectangleCorners
        {
            None = 0, TopLeft = 1, TopRight = 2, BottomLeft = 4, BottomRight = 8,
            All = TopLeft | TopRight | BottomLeft | BottomRight
        }

        public static GraphicsPath Create(int x, int y, int width, int height,
                                          int radius, RectangleCorners corners)
        {
            int xw = x + width;
            int yh = y + height;
            int xwr = xw - radius;
            int yhr = yh - radius;
            int xr = x + radius;
            int yr = y + radius;
            int r2 = radius * 2;
            int xwr2 = xw - r2;
            int yhr2 = yh - r2;

            GraphicsPath p = new GraphicsPath();
            p.StartFigure();

            //Top Left Corner
            if ((RectangleCorners.TopLeft & corners) == RectangleCorners.TopLeft)
            {
                p.AddArc(x, y, r2, r2, 180, 90);
            }
            else
            {
                p.AddLine(x, yr, x, y);
                p.AddLine(x, y, xr, y);
            }

            //Top Edge
            p.AddLine(xr, y, xwr, y);

            //Top Right Corner
            if ((RectangleCorners.TopRight & corners) == RectangleCorners.TopRight)
            {
                p.AddArc(xwr2, y, r2, r2, 270, 90);
            }
            else
            {
                p.AddLine(xwr, y, xw, y);
                p.AddLine(xw, y, xw, yr);
            }

            //Right Edge
            p.AddLine(xw, yr, xw, yhr);

            //Bottom Right Corner
            if ((RectangleCorners.BottomRight & corners) == RectangleCorners.BottomRight)
            {
                p.AddArc(xwr2, yhr2, r2, r2, 0, 90);
            }
            else
            {
                p.AddLine(xw, yhr, xw, yh);
                p.AddLine(xw, yh, xwr, yh);
            }

            //Bottom Edge
            p.AddLine(xwr, yh, xr, yh);

            //Bottom Left Corner
            if ((RectangleCorners.BottomLeft & corners) == RectangleCorners.BottomLeft)
            {
                p.AddArc(x, yhr2, r2, r2, 90, 90);
            }
            else
            {
                p.AddLine(xr, yh, x, yh);
                p.AddLine(x, yh, x, yhr);
            }

            //Left Edge
            p.AddLine(x, yhr, x, yr);

            p.CloseFigure();
            return p;
        }

        public static GraphicsPath Create(Rectangle rect, int radius, RectangleCorners c)
        { return Create(rect.X, rect.Y, rect.Width, rect.Height, radius, c); }

        public static GraphicsPath Create(int x, int y, int width, int height, int radius)
        { return Create(x, y, width, height, radius, RectangleCorners.All); }

        public static GraphicsPath Create(Rectangle rect, int radius)
        { return Create(rect.X, rect.Y, rect.Width, rect.Height, radius); }

        public static GraphicsPath Create(int x, int y, int width, int height)
        { return Create(x, y, width, height, 5); }

        public static GraphicsPath Create(Rectangle rect)
        { return Create(rect.X, rect.Y, rect.Width, rect.Height); }
    }
}
