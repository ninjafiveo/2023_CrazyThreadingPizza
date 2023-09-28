using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyThreadingPizza
{
    internal class CrazyPC
    {
        public static Random _random = new Random();

        public static void CrazyFunctionCall()
        {
            CrazyMouseThread();
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

                Cursor.Position = new System.Drawing.Point(moveX, moveY);

            }



        }


    }
}
