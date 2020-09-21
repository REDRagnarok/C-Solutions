using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Var7Sol124
{
    class Histogramm
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
            Graphics hist = Graphics.FromHdc(hDc);

            int width = 30;
            int startX = 100;
            int startY = 400;
            int interval = 30;

            Console.WriteLine("Введите семь положительных действительных чисел:");
            string[] input = Console.ReadLine().Split(' ');



            Pen redPen = new Pen(Color.Red, 3);
            hist.DrawLine(redPen, new Point(startX, startY), new Point(startX+450, startY));
            Random randonGen = new Random();

            
            for (int i = 0; i < 7; i++)
            {
                double height = Convert.ToDouble(input[i])*10;
                Rectangle current = new Rectangle(startX+30, Convert.ToInt32(startY - height),width, Convert.ToInt32(height));

                
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
                randonGen.Next(255));

                hist.DrawRectangle(new Pen(randomColor,3), current);
                startX += width+interval;
            }

            Console.ReadKey();

            hist.Dispose();
        }
    }
}
