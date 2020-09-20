using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Var7Sol120
{
    class Canvas
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        
        [DllImport("user32.dll")]
        public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteDC(IntPtr hDc);

        static void Main(string[] args)
        {

            IntPtr hWnd = GetConsoleWindow();
            IntPtr hDc = GetDC(hWnd);
            Graphics canvas = Graphics.FromHdc(hDc);

            Pen redPen = new Pen(Color.Red,2);

            Point[] TriA = { new Point(100, 100), new Point(150, 100), new Point(80, 170) };
            canvas.DrawPolygon(redPen, TriA);
            canvas.FillPolygon(new SolidBrush(Color.Yellow),TriA);

            Point[] RectB = { new Point(180, 80), new Point(270, 80), new Point(270, 150), new Point(180, 150) };
            canvas.DrawPolygon(new Pen(Color.Magenta, 2), RectB);
            canvas.FillPolygon(new SolidBrush(Color.Green), RectB);

            Point[] PolyC = { new Point(300, 100), new Point(350, 100), new Point(370, 120), new Point(350, 140), new Point (300,140) };
            canvas.DrawPolygon(new Pen(Color.Blue, 2), PolyC);
            canvas.FillPolygon(new SolidBrush(Color.Orange), PolyC);

            Point[] HexA = { new Point(420, 100), new Point(440, 120), new Point(440, 140), new Point(420, 160), new Point(400, 140),new Point(400,120) };
            canvas.DrawPolygon(new Pen(Color.Brown, 2), HexA);
            canvas.FillPolygon(new SolidBrush(Color.Cyan), HexA);

            Console.ReadKey();
        }
    }
}
