using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ReadWriteProcessMemory
{
    public class ProcessMemory
    {
        [DllImport("kernel32.dll")]public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);
        byte[] buffer = new byte[4];
        public IntPtr handle;
        public int baseAddress;

        //constructor
        public ProcessMemory(string pName)
        {
            Process process = Process.GetProcessesByName(pName)[0];
            handle = OpenProcess(0x001F0FFF, false, process.Id);
            baseAddress = process.MainModule.BaseAddress.ToInt32();
        }

        //parents
        public byte[] readBytes(int pAddress, int pSize)
        {
            byte[] buffer = new byte[pSize];
            int read = 0;
            ReadProcessMemory((int)handle, pAddress, buffer, pSize, ref read);
            return buffer;
        }

        public void writeBytes(int pAddress, byte[] pBuffer)
        {
            int written = 0;
            WriteProcessMemory((int)handle, pAddress, pBuffer, pBuffer.Length, ref written);
        }

        //reading children
        public byte readByte(int pAddress)
        {
            return readBytes(pAddress, 1)[0];
        }

        public sbyte readSByte(int pAddress)
        {
            return (sbyte)readBytes(pAddress, 1)[0];
        }

        public short readShort(int pAddress)
        {
            return BitConverter.ToInt16(readBytes(pAddress, 2), 0);
        }

        public ushort readUShort(int pAddress)
        {
            return BitConverter.ToUInt16(readBytes(pAddress, 2), 0);
        }

        public int readInt(int pAddress)
        {
            return BitConverter.ToInt32(readBytes(pAddress, 4), 0);
        }

        public uint readUInt(int pAddress)
        {
            return BitConverter.ToUInt32(readBytes(pAddress, 4), 0);
        }

        //writing children
        public void writeByte(int pAddress, byte pValue)
        {
            writeBytes(pAddress, new byte[] { pValue });
        }

        public void writeSByte(int pAddress, sbyte pValue)
        {
            //writeBytes(pAddress, BitConverter.GetBytes(pValue));
            writeBytes(pAddress, new byte[] { (byte)pValue });
        }

        public void writeShort(int pAddress, short pValue)
        {
            writeBytes(pAddress, BitConverter.GetBytes(pValue));
        }

        public void writeUShort(int pAddress, ushort pValue)
        {
            writeBytes(pAddress, BitConverter.GetBytes(pValue));
        }

        public void writeInt(int pAddress, int pValue)
        {
            writeBytes(pAddress, BitConverter.GetBytes(pValue));
        }

        public void writeUInt(int pAddress, uint pValue)
        {
            writeBytes(pAddress, BitConverter.GetBytes(pValue));
        }
    }
}