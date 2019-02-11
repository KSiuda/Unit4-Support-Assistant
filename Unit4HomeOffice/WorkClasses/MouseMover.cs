using System;
using System.Threading;
using System.Windows.Forms;

namespace Unit4HomeOffice
{
    public class MouseMover
    {
        public Thread GhostMouse(bool move)
        {
            return new Thread(() => ghostMove(move));
        }

        public void ghostMove(bool move)
        {
            while (move)
            {
                Random random = new Random();
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + random.Next(0, 500), Cursor.Position.Y + random.Next(0, 500));
                Thread.Sleep(500);
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X - +random.Next(0, 500), Cursor.Position.Y - +random.Next(0, 500));

            }
        }
    }
}
