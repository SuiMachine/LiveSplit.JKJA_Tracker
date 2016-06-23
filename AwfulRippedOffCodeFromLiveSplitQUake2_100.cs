using LiveSplit.ComponentUtil;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace LiveSplit.JKJA_Tracker
{
    //This code was completely ripped off from SphereMJ - thanks Sphere :)

    class AwfulRippedOffCode
    {
        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumProcessModulesEx(IntPtr hProcess, [Out] IntPtr[] lphModule, uint cb,
            out uint lpcbNeeded, uint dwFilterFlag);

        [DllImport("psapi.dll")]
        private static extern uint GetModuleBaseName(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName,
            uint nSize);

        [DllImport("psapi.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetModuleInformation(IntPtr hProcess, IntPtr hModule, [Out] out MODULEINFO lpmodinfo,
          uint cb);

        [StructLayout(LayoutKind.Sequential)]
        public struct MODULEINFO
        {
            public IntPtr lpBaseOfDll;
            public uint SizeOfImage;
            public IntPtr EntryPoint;
        }


        public static IntPtr GetGameModuleBase(Process gameProcess)
        {
            const int LIST_MODULES_ALL = 5;
            const int MAX_PATH = 260;
            var hModules = new IntPtr[1024];

            uint cb = (uint)IntPtr.Size * (uint)hModules.Length;
            uint cbNeeded;
            if (!EnumProcessModulesEx(gameProcess.Handle, hModules, cb, out cbNeeded, LIST_MODULES_ALL))
                throw new Win32Exception();
            uint numMods = cbNeeded / (uint)IntPtr.Size;

            var sb = new StringBuilder(MAX_PATH);
            for (int i = 0; i < numMods; i++)
            {
                sb.Clear();
                if (GetModuleBaseName(gameProcess.Handle, hModules[i], sb, (uint)sb.Capacity) == 0)
                    throw new Win32Exception();
                string baseName = sb.ToString();

                if (baseName.ToLower() == "jagamex86.dll")
                {
                    var moduleInfo = new MODULEINFO();
                    if (!GetModuleInformation(gameProcess.Handle, hModules[i], out moduleInfo,
                                              (uint)Marshal.SizeOf(moduleInfo)))
                    {
                        throw new Win32Exception();
                    }
                    return moduleInfo.lpBaseOfDll;
                }
            }

            return IntPtr.Zero;
        }
    }
}