using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace Master.MouseSystem
{
    public class MouseDevice
    {
        public IntPtr Handle;
        public string DevicePath;
        public string Name;
        public string VID;
        public string PID;
    }

    public static class MouseDetector
    {
        public static List<MouseDevice> GetMice()
        {
            List<MouseDevice> list = new();

            uint deviceCount = 0;

            GetRawInputDeviceList(
                null,
                ref deviceCount,
                (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST)));

            if (deviceCount == 0)
                return list;

            RAWINPUTDEVICELIST[] devices =
                new RAWINPUTDEVICELIST[deviceCount];

            GetRawInputDeviceList(
                devices,
                ref deviceCount,
                (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST)));

            foreach (var device in devices)
            {
                if (device.dwType != 0) // 0 = Mouse
                    continue;

                string path = GetDeviceName(device.hDevice);

                string vid = ExtractVID(path);
                string pid = ExtractPID(path);

                var mouse = new MouseDevice
                {
                    Handle = device.hDevice,
                    DevicePath = path,
                    VID = vid,
                    PID = pid,
                    Name = GetDeviceFriendlyName(path, vid, pid)
                };

                list.Add(mouse);
            }

            return list;
        }

        static string GetDeviceName(IntPtr handle)
        {
            uint size = 0;

            GetRawInputDeviceInfo(
                handle,
                RIDI_DEVICENAME,
                null,
                ref size);

            if (size == 0)
                return "";

            StringBuilder sb = new((int)size);

            GetRawInputDeviceInfo(
                handle,
                RIDI_DEVICENAME,
                sb,
                ref size);

            return sb.ToString();
        }

        static string GetDeviceFriendlyName(string devicePath, string vid, string pid)
        {
            try
            {
                if (string.IsNullOrEmpty(vid) || string.IsNullOrEmpty(pid))
                    return "Unknown Mouse";

                string registryPath =
                    $@"SYSTEM\CurrentControlSet\Enum\HID\VID_{vid}&PID_{pid}";

                using var key =
                    Registry.LocalMachine.OpenSubKey(registryPath);

                if (key == null)
                    return $"Mouse VID_{vid}&PID_{pid}";

                foreach (var subKeyName in key.GetSubKeyNames())
                {
                    using var deviceKey =
                        key.OpenSubKey(subKeyName);

                    if (deviceKey == null)
                        continue;

                    string friendlyName =
                        deviceKey.GetValue("FriendlyName")?.ToString();

                    if (!string.IsNullOrEmpty(friendlyName))
                        return CleanName(friendlyName);

                    string deviceDesc =
                        deviceKey.GetValue("DeviceDesc")?.ToString();

                    if (!string.IsNullOrEmpty(deviceDesc))
                        return CleanName(deviceDesc);
                }
            }
            catch
            {
            }

            return $"Mouse VID_{vid}&PID_{pid}";
        }

        static string CleanName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return "";

            int index = name.IndexOf(';');

            if (index >= 0)
                name = name.Substring(index + 1);

            return name.Trim();
        }

        static string ExtractVID(string path)
        {
            int vidIndex = path.IndexOf("VID_");

            if (vidIndex == -1)
                return "";

            return path.Substring(vidIndex + 4, 4);
        }

        static string ExtractPID(string path)
        {
            int pidIndex = path.IndexOf("PID_");

            if (pidIndex == -1)
                return "";

            return path.Substring(pidIndex + 4, 4);
        }

        const uint RIDI_DEVICENAME = 0x20000007;

        [DllImport("User32.dll")]
        static extern uint GetRawInputDeviceList(
            RAWINPUTDEVICELIST[] list,
            ref uint count,
            uint size);

        [DllImport("User32.dll")]
        static extern uint GetRawInputDeviceInfo(
            IntPtr device,
            uint command,
            StringBuilder data,
            ref uint size);

        [StructLayout(LayoutKind.Sequential)]
        struct RAWINPUTDEVICELIST
        {
            public IntPtr hDevice;
            public uint dwType;
        }
    }
}
