using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml;
using System.Drawing;

namespace systemnomcheat
{
    class GetScreenShot
    {

        public Bitmap GetScreen()
        {
            IntPtr hWnd = GetForegroundWindow();

            Size wSize = GetControlSize(hWnd);
            Bitmap screenshot = new Bitmap(wSize.Width, wSize.Height);
            Graphics graphics = Graphics.FromImage(screenshot as Image);
            graphics.CopyFromScreen(GetControlPoint(hWnd), new Point(0, 0), screenshot.Size);

            return screenshot;

        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }



        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private static Size GetControlSize(IntPtr hWnd)
        {
            RECT pRect;
            Size cSize = new Size();
            // get coordinates relative to window
            GetWindowRect(hWnd, out pRect);

            cSize.Width = pRect.Right - pRect.Left;
            cSize.Height = pRect.Bottom - pRect.Top;

            return cSize;
        }

        private static Point GetControlPoint(IntPtr hWnd)
        {
            RECT pRect;
            // get coordinates relative to window
            GetWindowRect(hWnd, out pRect);

            Point wPoint = new Point(pRect.Left, pRect.Top);


            return wPoint;
        }

    }
}
