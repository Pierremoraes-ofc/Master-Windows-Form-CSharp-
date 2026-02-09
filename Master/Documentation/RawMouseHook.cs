using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Master.MouseSystem
{
    /// Representa um evento de mouse capturado via Raw Input.
    /// Contém informações sobre botão, tipo do evento,
    /// movimento, wheel e qual dispositivo físico gerou o evento.
    public class MouseEvent
    {        
        /// Botão que gerou o evento.
        public ButtonMouse Button;
        
        /// Tipo do evento: Down, Up, Wheel ou Move.
        public MouseEventType Type;
        
        /// Delta da roda do mouse.
        public int Delta;
        
        /// Movimento relativo no eixo X.
        public int X;
        
        /// Movimento relativo no eixo Y.
        public int Y;
        
        /// Handle do dispositivo físico que gerou o evento.
        /// Essencial para diferenciar múltiplos mouses.
        public IntPtr DeviceHandle;
    }

    
    /// Classe responsável por capturar eventos do mouse usando Raw Input.
    /// Permite detectar botões, wheel e movimento, incluindo o dispositivo específico.
    public class RawMouseHook : NativeWindow
    {
        
        /// Evento disparado sempre que um evento de mouse é detectado.
        public event Action<MouseEvent> MouseEvent;

        const int WM_INPUT = 0x00FF;

        // RAW INPUT FLAGS
        const ushort RI_MOUSE_LEFT_BUTTON_DOWN = 0x0001;
        const ushort RI_MOUSE_LEFT_BUTTON_UP = 0x0002;

        const ushort RI_MOUSE_RIGHT_BUTTON_DOWN = 0x0004;
        const ushort RI_MOUSE_RIGHT_BUTTON_UP = 0x0008;

        const ushort RI_MOUSE_MIDDLE_BUTTON_DOWN = 0x0010;
        const ushort RI_MOUSE_MIDDLE_BUTTON_UP = 0x0020;

        const ushort RI_MOUSE_BUTTON_4_DOWN = 0x0040;
        const ushort RI_MOUSE_BUTTON_4_UP = 0x0080;

        const ushort RI_MOUSE_BUTTON_5_DOWN = 0x0100;
        const ushort RI_MOUSE_BUTTON_5_UP = 0x0200;

        const ushort RI_MOUSE_WHEEL = 0x0400;

        
        /// Inicializa o hook e registra o Raw Input no handle da janela.
        public RawMouseHook(IntPtr handle)
        {
            AssignHandle(handle);
            RegisterRawInput(handle);
        }

        
        /// Registra o dispositivo de mouse para receber eventos Raw Input.
        private void RegisterRawInput(IntPtr hwnd)
        {
            RAWINPUTDEVICE[] rid = new RAWINPUTDEVICE[1];

            rid[0].usUsagePage = 0x01;
            rid[0].usUsage = 0x02;
            rid[0].dwFlags = 0;
            rid[0].hwndTarget = hwnd;

            RegisterRawInputDevices(
                rid,
                (uint)rid.Length,
                (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICE)));
        }

        
        /// Intercepta mensagens da janela.
        /// Detecta WM_INPUT e processa os dados do mouse.
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_INPUT)
            {
                ProcessRawInput(m.LParam);
            }

            base.WndProc(ref m);
        }

        
        /// Processa os dados Raw Input recebidos do Windows.
        /// Converte em MouseEvent e dispara o evento.
        private void ProcessRawInput(IntPtr hRawInput)
        {
            uint size = 0;

            GetRawInputData(
                hRawInput,
                RID_INPUT,
                IntPtr.Zero,
                ref size,
                (uint)Marshal.SizeOf(typeof(RAWINPUTHEADER)));

            if (size == 0)
                return;

            IntPtr buffer = Marshal.AllocHGlobal((int)size);

            try
            {
                GetRawInputData(
                    hRawInput,
                    RID_INPUT,
                    buffer,
                    ref size,
                    (uint)Marshal.SizeOf(typeof(RAWINPUTHEADER)));

                RAWINPUT raw =
                    Marshal.PtrToStructure<RAWINPUT>(buffer);

                // Verifica se é mouse
                if (raw.header.dwType != 0)
                    return;

                var mouse = raw.mouse;
                var deviceHandle = raw.header.hDevice;

                // MOVE
                if (mouse.lLastX != 0 || mouse.lLastY != 0)
                {
                    MouseEvent?.Invoke(new MouseEvent
                    {
                        Button = ButtonMouse.Move,
                        Type = MouseEventType.Move,
                        X = mouse.lLastX,
                        Y = mouse.lLastY,
                        DeviceHandle = deviceHandle
                    });
                }

                // LEFT
                if ((mouse.usButtonFlags & RI_MOUSE_LEFT_BUTTON_DOWN) != 0)
                    Raise(ButtonMouse.Left, MouseEventType.Down, deviceHandle);

                if ((mouse.usButtonFlags & RI_MOUSE_LEFT_BUTTON_UP) != 0)
                    Raise(ButtonMouse.Left, MouseEventType.Up, deviceHandle);

                // RIGHT
                if ((mouse.usButtonFlags & RI_MOUSE_RIGHT_BUTTON_DOWN) != 0)
                    Raise(ButtonMouse.Right, MouseEventType.Down, deviceHandle);

                if ((mouse.usButtonFlags & RI_MOUSE_RIGHT_BUTTON_UP) != 0)
                    Raise(ButtonMouse.Right, MouseEventType.Up, deviceHandle);

                // MIDDLE
                if ((mouse.usButtonFlags & RI_MOUSE_MIDDLE_BUTTON_DOWN) != 0)
                    Raise(ButtonMouse.Middle, MouseEventType.Down, deviceHandle);

                if ((mouse.usButtonFlags & RI_MOUSE_MIDDLE_BUTTON_UP) != 0)
                    Raise(ButtonMouse.Middle, MouseEventType.Up, deviceHandle);

                // XBUTTON 1
                if ((mouse.usButtonFlags & RI_MOUSE_BUTTON_4_DOWN) != 0)
                    Raise(ButtonMouse.XButton1, MouseEventType.Down, deviceHandle);

                if ((mouse.usButtonFlags & RI_MOUSE_BUTTON_4_UP) != 0)
                    Raise(ButtonMouse.XButton1, MouseEventType.Up, deviceHandle);

                // XBUTTON 2
                if ((mouse.usButtonFlags & RI_MOUSE_BUTTON_5_DOWN) != 0)
                    Raise(ButtonMouse.XButton2, MouseEventType.Down, deviceHandle);

                if ((mouse.usButtonFlags & RI_MOUSE_BUTTON_5_UP) != 0)
                    Raise(ButtonMouse.XButton2, MouseEventType.Up, deviceHandle);

                // WHEEL
                if ((mouse.usButtonFlags & RI_MOUSE_WHEEL) != 0)
                {
                    short delta = (short)mouse.usButtonData;

                    MouseEvent?.Invoke(new MouseEvent
                    {
                        Button = delta > 0 ?
                            ButtonMouse.WheelUp :
                            ButtonMouse.WheelDown,

                        Type = MouseEventType.Wheel,
                        Delta = delta,
                        DeviceHandle = deviceHandle
                    });
                }
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        /// Método auxiliar para disparar eventos de botão.
        /// Garante que o DeviceHandle seja incluído.
        private void Raise(ButtonMouse button, MouseEventType type, IntPtr deviceHandle)
        {
            MouseEvent?.Invoke(new MouseEvent
            {
                Button = button,
                Type = type,
                DeviceHandle = deviceHandle
            });
        }

        const int RID_INPUT = 0x10000003;

        [DllImport("User32.dll")]
        static extern uint GetRawInputData(
            IntPtr hRawInput,
            uint command,
            IntPtr data,
            ref uint size,
            uint headerSize);

        [DllImport("User32.dll")]
        static extern bool RegisterRawInputDevices(
            RAWINPUTDEVICE[] devices,
            uint numDevices,
            uint size);

        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUTDEVICE
        {
            public ushort usUsagePage;
            public ushort usUsage;
            public int dwFlags;
            public IntPtr hwndTarget;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUTHEADER
        {
            public int dwType;
            public int dwSize;
            public IntPtr hDevice;
            public IntPtr wParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUT
        {
            public RAWINPUTHEADER header;
            public RAWMOUSE mouse;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RAWMOUSE
        {
            public ushort usFlags;
            public ushort usButtonFlags;
            public ushort usButtonData;
            public uint ulRawButtons;
            public int lLastX;
            public int lLastY;
            public uint ulExtraInformation;
        }
    }
}
