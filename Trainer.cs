﻿/* C# trainer class.
 * Author : Cless
 */

/*How to use pointer read/write.
 * ////// Example Read ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 *      this.Text = Trainer.ReadPointerInteger("Game exe name here",0xPointer here,new int[offset count] {0xOffset}).Tostring();
 *      Ex Read.
 *      this.Text = Trainer.ReadPointerInteger("gta_sa",0xB71A38,new int[1]{ 0x5412 }).Tostring();
 *      Or
 *      this.Text = Trainer.ReadPointerInteger("gta_sa",0xB71A38,new int[5]{ 0x540, 0x541, 0x542, 0x543, 0x544, 0x545 }).Tostring();
 * ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 * ///// Example Write ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
 *      Trainer.WritePointerInteger("Game exe name here", 0xPointer here, new int[offset count] {0xoffset});
 *      Trainer.WritePointerInteger("gta_sa", 0xB71A38, new int[1] { 0x540 }, 1000);
 *      Or
 *      Trainer.WritePointerInteger("gta_sa",0xB71A38,new int[5]{ 0x540, 0x541, 0x542, 0x543, 0x544, 0x545 },10000);
 * ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////     
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;


public class Trainer
{
    private const int PROCESS_ALL_ACCESS = 0x1F0FFF;
    [DllImport("kernel32")]
    private static extern int OpenProcess(int AccessType, int InheritHandle, int ProcessId);


    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern byte ReadProcessMemoryByte(int Handle, int Address, ref byte Value, int Size, ref int BytesRead);
    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern int ReadProcessMemoryInteger(int Handle, int Address, ref int Value, int Size, ref int BytesRead);
    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern float ReadProcessMemoryFloat(int Handle, int Address, ref float Value, int Size, ref int BytesRead);
    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern double ReadProcessMemoryDouble(int Handle, int Address, ref double Value, int Size, ref int BytesRead);
    [DllImport("kernel32")]
    private static extern int CloseHandle(int Handle);

    [DllImport("user32")]
    private static extern int FindWindow(string sClassName, string sAppName);
    [DllImport("user32")]
    private static extern int GetWindowThreadProcessId(int HWND, out int processId);


    public static string CheckGame(string WindowTitle)
    {
        string result = "";
        checked
        {
            try
            {
                int Proc;
                int HWND = FindWindow(null, WindowTitle);
                GetWindowThreadProcessId(HWND, out Proc);
                int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc);
                if (Handle != 0)
                {
                    result = "Game is running...";
                }
                else
                {
                    result = "Game is not running...";
                }
                CloseHandle(Handle);
            }
            catch
            { }
        }
        return result;
    }
    public static byte ReadByte(Process Proc, int Address)
    {
        byte Value = 0;
        checked
        {
            try
            {
                if (Proc != null)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc.Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryByte(Handle, Address, ref Value, 2, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static int ReadInteger(Process Proc, int Address)
    {
        int Value = 0;
        checked
        {
            try
            {
                if (Proc != null)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc.Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryInteger(Handle, Address, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static float ReadFloat(Process Proc, int Address)
    {
        float Value = 0;
        checked
        {
            try
            {
                if (Proc != null)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc.Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryFloat((int)Handle, Address, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static double ReadDouble(Process Proc, int Address)
    {
        double Value = 0;
        checked
        {
            try
            {
                if (Proc != null)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc.Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryDouble((int)Handle, Address, ref Value, 8, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }

    public static byte ReadPointerByte(Process Proc, int Pointer, int[] Offset)
    {
        byte Value = 0;
        checked
        {
            try
            {
                if (Proc != null)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc.Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryByte((int)Handle, Pointer, ref Value, 2, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static int ReadPointerInteger(Process Proc, int Pointer, int[] Offset)
    {
        int Value = 0;
        checked
        {
            try
            {
                if (Proc != null)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc.Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryInteger((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static float ReadPointerFloat(Process Proc, int Pointer, int[] Offset)
    {
        float Value = 0;
        checked
        {
            try
            {
                if (Proc != null)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc.Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryFloat((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
}