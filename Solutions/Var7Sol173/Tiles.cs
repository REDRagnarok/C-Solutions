using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Var7Sol173
{
    class Tiles
    {


        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
               
        [DllImport("user32.dll")]
        public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, IntPtr rect);

        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteDC(IntPtr hDc);

        static void Main(string[] args)
        {
            IntPtr hWnd = GetConsoleWindow();
            IntPtr hDc = GetDC(hWnd);
            Graphics Pad = Graphics.FromHdc(hDc);

            Random coord = new Random();
            Random randonGen = new Random();
            
            for (int k = 0; k < 200; k++) 
            {
               
                int Y = coord.Next(0, Console.WindowHeight*12);
                int X = coord.Next(0, Console.WindowWidth*10);
                int W = coord.Next(0, Console.WindowHeight*5);
                int H = coord.Next(0, Console.WindowWidth*5);
                Rectangle current = new Rectangle(X, Y, H, W);

                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
                randonGen.Next(255));

                Pad.FillRectangle(new SolidBrush(randomColor), current);
                
            }

            Console.ReadKey();
        }
    }
}
