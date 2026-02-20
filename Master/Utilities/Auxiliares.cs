using System.Diagnostics;
using static Master.WinApi;
using static Master.Actions.Ax;

namespace Master.Utilities
{
    internal static class Auxiliares
    {
        private static Ponteiro mp;

        internal static bool IsPressed(KeyN key) => (GetAsyncKeyState((int)key) & 0x8000) > 0;

        internal static Modificador GetPressedModificador()
        {
            if (IsKeyLaunchedDown) return Modificador.None;  // temp

            var mods = Modificador.None;

            if (IsPressed(KeyN.SHIFT)) mods |= Modificador.Shift;
            if (IsPressed(KeyN.CONTROL)) mods |= Modificador.Control;
            if (IsPressed(KeyN.MENU)) mods |= Modificador.Alt;
            if (IsPressed(KeyN.WIN_L) || IsPressed(KeyN.WIN_R)) mods |= Modificador.Win;

            return mods;
        }

        internal static WinApi.Ponteiro GetRataPos()
        {
            GetCursorPos(ref mp);
            return mp;
        }

        internal static string GetAppExeName() =>
            Process.GetProcessById(GetCursorProcessID()).ProcessName;

        internal static int GetCursorProcessID()
        {
            GetWindowThreadProcessId(getCursorHandle(), out int processID);
            return processID;
        }

        private static IntPtr getCursorHandle() => WindowFromPoint(GetRataPos());

        internal static IntPtr GetCursorMainHandle() => GetCursorMainHandle(GetRataPos());

        internal static IntPtr GetCursorMainHandle(Ponteiro rataPos) => GetAncestor(WindowFromPoint(rataPos), Ancestro.GetRoot);

        internal static void RunComando(AppComando cmd) => PostMessage(GetCursorMainHandle(), WM_APPCOMMAND, nint.Zero, (int)cmd << 16);
    }

}
