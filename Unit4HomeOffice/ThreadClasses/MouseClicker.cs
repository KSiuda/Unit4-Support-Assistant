using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Unit4HomeOffice
{
    public class MouseClicker   
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        public Thread GhostMouse(bool move, Main main)
        {
            return new Thread(() => ghostMove(move, main));
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void ghostMove(bool move, Main form)
        {

            Cursor.Position = new System.Drawing.Point(Cursor.Position.X + 300, Cursor.Position.Y);

            while (move)
            {
                form.labelMouse.Invoke(new Action(() => form.labelMouse.Visible = true));
                Thread.Sleep(5000);
                DoMouseClick();
                /*Random random = new Random();
                Thread.Sleep(500);
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X - +random.Next(0, 500), Cursor.Position.Y - +random.Next(0, 500));
                */
            }

           
        }
    }
}
