using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyThreadingPizza
{
    internal class CrazyPC
    {
        public static Random _random = new Random();

        public static void CrazyFunctionCall()
        {
            Thread crazyMouseThread = new Thread(new ThreadStart(CrazyMouseThread));
            Thread crazyKeyboardThread = new Thread(new ThreadStart(CrazyKeyboardThread));

            crazyMouseThread.Start();
            crazyKeyboardThread.Start();
        }

        static void CrazyMouseThread()
        {
            Trace.WriteLine("Crazy Mouse Started.");

            int moveX = 0;
            int moveY = 0;

            while (true)
            {
                moveX = _random.Next(30) - 15;
                moveY = _random.Next(30) - 15;

                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(100);
            }
        }

        static void CrazyKeyboardThread()
        {
            Trace.WriteLine("Crazy Keyboard Thread Started.");

            //char key = (char)(_random.Next(50) + 15);
            while (true)
            {
                // Create random character key.
                char key = (char)(_random.Next(50) + 45);

                if (_random.Next(2) == 0)
                {
                    key = char.ToLower(key);
                }
                //SendKeys.SendWait(key.ToString());
                try
                {
                    SendKeys.SendWait(key.ToString());
                }
                catch (Exception)
                {
                    Trace.WriteLine("Error Alert");
                    throw;
                }
                //SendKeys.SendWait(key.ToString());
                Thread.Sleep(500);
            }
        }

        public static void FreddieKreuger()
        {
            
        }
    }
}
