using static Master.WinApi;

namespace Master.Actions
{
    internal static partial class Ax
    {
        private static Input[] mouseInput;

        public static void LanzarMouseEvent(MouseN mb, int? mousedata = null)
        {
            mouseInput[0].union.mouse.dwFlags = mb;
            if (mousedata != null)
                mouseInput[0].union.mouse.mouseData = (int)mousedata;

            SendInput(1, mouseInput, GenSize);
        }
    }
}
