using System.Runtime.InteropServices;
using System.Text;

namespace Master
{
    internal static class WinApi
    {
        #region VARIAVEIS 

        public const int WM_APPCOMMAND = 0x319;
        internal const uint SPI_GET_MOUSESPEED = 0x0070;      //112
        internal const uint SPI_SET_MOUSESPEED = 0x0071;      //113
        internal const uint SPIF_UPDATEINIFILE = 0x01;
        internal const uint SPIF_SENDCHANGE = 0x02;
        internal const short SWP_NOSIZE = 1;
        internal const short SWP_NOZORDER = 0X0004;

        internal const uint INPUT_KEYBOARD = 1;

        internal const uint KEYEVENTF_KEYDOWN = 0x0000;
        internal const uint KEYEVENTF_KEYUP = 0x0002;
        internal const uint KEYEVENTF_SCANCODE = 0x0008;

        public const int WH_MOUSE_LL = 14;

        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;

        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_RBUTTONUP = 0x205;

        public const int WM_MBUTTONDOWN = 0x207;
        public const int WM_MBUTTONUP = 0x208;

        public const int WM_XBUTTONDOWN = 0x20B;
        public const int WM_XBUTTONUP = 0x20C;

        internal static readonly int GenSize = Marshal.SizeOf<Input>();

        #endregion

        #region STRUCTS

        [StructLayout(LayoutKind.Sequential)]
        internal struct Ponteiro
        {
            internal int x, y;
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct RAWINPUTDEVICE
        {
            public ushort usUsagePage;
            public ushort usUsage;
            public int dwFlags;
            public IntPtr hwndTarget;
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct RAWINPUTDEVICELIST
        {
            public IntPtr hDevice;
            public uint dwType;
        }
        public struct RectAPI
        {
            public int left, top, right, bottom;
        }
        internal enum Ancestro
        {
            GetParent = 1,
            GetRoot = 2,
            GetRootOwner = 3
        }
        [StructLayout(LayoutKind.Explicit)]
        internal struct InputUnion
        {
            [FieldOffset(0)]
            public KEYBDINPUT ki;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct Input
        {
            public InputEventType type;
            public MKH_InputUnion union;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MKH_InputUnion
        {
            [FieldOffset(0)]
            public MouseInput mouse;

            [FieldOffset(0)]
            public KeyboardInput keyboard;

            [FieldOffset(0)]
            public HardwareInput hardware;
        }

        internal enum InputEventType : int
        {
            Mouse = 0,
            Keyboard = 1,
            Hardware = 2
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct HardwareInput
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MouseInput
        {
            internal int dx;
            internal int dy;
            internal int mouseData;
            internal MouseN dwFlags;
            internal uint time;
            internal nint dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct KeyboardInput
        {
            internal KeyN wVk;
            internal ushort wScan;
            internal KbFlags dwFlags;
            internal uint time;
            internal nint dwExtraInfo;
        }

        #endregion

        #region WINDOWS user32.dll
        // GET
        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr handle);

        [DllImport("user32.dll")]
        public static extern bool IsZoomed(IntPtr handle);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        // SET
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern bool SwitchToThisWindow(IntPtr handle, bool funknow);

        // MOVER
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool GetWindowRect(IntPtr hWnd, out RectAPI lpRect);

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern IntPtr SetWindowPos(IntPtr hadnle, int hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        [DllImport("user32.dll")]
        internal static extern IntPtr WindowFromPoint(WinApi.Ponteiro p);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetAncestor(IntPtr hwnd, Ancestro gaFlags);

        [DllImport("user32.dll")]
        internal static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

        [DllImport("User32.dll")]
        internal static extern short GetAsyncKeyState(int keyCode);

        [DllImport("User32.dll", SetLastError = true)]
        internal static extern Boolean SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, IntPtr pvParam, UInt32 fWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
        public static extern bool GetMouseSpeed(uint uiAction, uint uiParam, out uint pvParam, uint fWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
        public static extern bool SetMouseSpeed(uint uiAction, uint uiParam, uint pvParam, uint fWinIni);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "ClipCursor")]
        internal static extern void ClipCursor(RectAPI lpRect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "ClipCursor")]
        internal static extern int UnclipCursor(nint nullLpRect);

        [DllImport("user32.dll")]
        internal static extern bool PostMessage(nint hWnd, uint Msg, nint wParam, int lParam);

        [DllImport("user32.dll")]
        internal static extern int GetSystemMetrics(int nIndex);

        [DllImport("User32.dll")]
        internal static extern uint GetRawInputData(
            IntPtr hRawInput,
            uint command,
            IntPtr data,
            ref uint size,
            uint headerSize);

        [DllImport("User32.dll")]
        internal static extern bool RegisterRawInputDevices(
            RAWINPUTDEVICE[] devices,
            uint numDevices,
            uint size);

        [DllImport("User32.dll")]
        internal static extern uint GetRawInputDeviceList(
            RAWINPUTDEVICELIST[] list,
            ref uint count,
            uint size);

        [DllImport("User32.dll")]
        internal static extern uint GetRawInputDeviceInfo(
            IntPtr device,
            uint command,
            StringBuilder data,
            ref uint size);


        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(ref Ponteiro pt);

        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(out Point pt);

        // Wrapper flexível
        public static T GetCursor<T>() where T : struct
        {
            if (typeof(T) == typeof(Point))
            {
                GetCursorPos(out Point p);
                return (T)(object)p;
            }
            else if (typeof(T) == typeof(Ponteiro))
            {
                Ponteiro pt = new Ponteiro();
                GetCursorPos(ref pt);
                return (T)(object)pt;
            }
            else
            {
                throw new NotSupportedException($"Tipo {typeof(T)} não suportado!");
            }
        }
        //[DllImport("user32.dll")]
        //internal static extern bool GetCursorPos(out Ponteiro pt);
        //internal static extern bool GetCursorPos(ref WinApi.Ponteiro pt);

        [DllImport("user32.dll")]
        internal static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        //[DllImport("user32.dll", SetLastError = true)]
        //internal static extern uint SendInput(uint numInputs, Input[] inputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(
            int idHook,
            Delegate lpfn,
            IntPtr hMod,
            uint dwThreadId);

        [DllImport("user32.dll")]
        public static extern bool UnhookWindowsHookEx(
            IntPtr hhk);

        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(
            IntPtr hhk,
            int nCode,
            IntPtr wParam,
            IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(
            string lpModuleName);

        [DllImport("user32.dll")]
        internal static extern uint MapVirtualKey(
            uint uCode,
            uint uMapType);

        #endregion
    }
}