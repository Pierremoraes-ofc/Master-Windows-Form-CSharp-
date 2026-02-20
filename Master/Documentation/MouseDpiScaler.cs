using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Master.WinApi;

namespace Master.MouseSystem
{
    public static class MouseDpiScaler
    {
        private static System.Windows.Forms.Timer timer;

        private static Point lastPos;

        private static float multiplier = 1.0f;

        private static bool enabled = false;


        //[DllImport("user32.dll")]
        //internal static extern bool GetCursorPos(out Point lpPoint);

        public static void Start(float dpiMultiplier)
        {
            multiplier = dpiMultiplier;

            if (timer == null)
            {
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1;
                timer.Tick += Update;
            }

            GetCursorPos(out lastPos);

            enabled = true;
            timer.Start();
        }

        public static void Stop()
        {
            enabled = false;

            timer?.Stop();
        }

        public static void SetMultiplier(float dpiMultiplier)
        {
            multiplier = dpiMultiplier;
        }

        public static float GetMultiplier()
        {
            return multiplier;
        }

        public static bool IsEnabled()
        {
            return enabled;
        }

        private static void Update(object sender, EventArgs e)
        {
            if (!enabled)
                return;

            GetCursorPos(out Point current);

            int dx = current.X - lastPos.X;
            int dy = current.Y - lastPos.Y;

            if (dx == 0 && dy == 0)
                return;

            int newX = lastPos.X + (int)(dx * multiplier);
            int newY = lastPos.Y + (int)(dy * multiplier);

            SetCursorPos(newX, newY);

            lastPos = new Point(newX, newY);
        }
    }
}
