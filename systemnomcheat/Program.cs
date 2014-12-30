using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml;
using System.IO;
using System.Drawing;
using System.Windows.Forms;





namespace systemnomcheat
{
    class Program
    {
        static void Main(string[] args)
        {
            GetScreenShot getScreenShot = new GetScreenShot();
            Bitmap screenshot;
            StringBuilder stringBuilder = new StringBuilder();

            while (true)
            {
                String wTitle = GetWindowTitle.GetActiveWindowTitle();
                if (!String.IsNullOrEmpty(wTitle))
                {
                    if (wTitle.Equals("Systems Nominal"))
                    {
                        
                        screenshot = getScreenShot.GetScreen();

                        for (int row=0;row<3;row++)
                        {
                            for (int key=0;key < 10-row;key++)
                            {

                                if (CompareColor(screenshot.GetPixel(270+90*key+45*row, 490+80*row)))
                                {

                                    stringBuilder.Append(GetKey.Get(key + row * 10 - row * (row - 1) * (row - 1) / 2));

                                    if (GetKey.Get(key + row * 10 - row * (row - 1) * (row - 1) / 2) == 20)
                                    {
                                        Console.WriteLine(270+90*key+45*row+":"+490+80*row);
                                    }


                                }
                                
                            }                            
                        }
                        
                        if (stringBuilder.Length > 0)
                        {
                            PressKeys.Write(stringBuilder.ToString());
                            Console.WriteLine("Pressing: " + stringBuilder.ToString());
                            stringBuilder.Clear();
                            System.Threading.Thread.Sleep(500);
                            
                        }
                    }
                }
            }
        }
        

        private static bool CompareColor (Color color)
        {

            if (color.R > 225 && color.G <150)
            {
                Console.WriteLine(color.R + ":" + color.G);
                return true;
            }
            
            return false;
        }
    }
}
