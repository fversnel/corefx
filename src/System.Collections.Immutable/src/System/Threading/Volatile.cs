using System.Security;

namespace System.Threading
{
    public static class Volatile
    {
        public static bool Read(ref bool location)
        {
            return false;
        }

        public static byte Read(ref byte location)
        {
            return (byte)0;
        }

        public static double Read(ref double location)
        {
            return 0.0;
        }

        public static short Read(ref short location)
        {
            return (short)0;
        }

        public static int Read(ref int location)
        {
            return 0;
        }

        public static long Read(ref long location)
        {
            return 0L;
        }

        public static IntPtr Read(ref IntPtr location)
        {
            return new IntPtr();
        }

        [CLSCompliant(false)]
        public static sbyte Read(ref sbyte location)
        {
            return (sbyte)0;
        }

        public static float Read(ref float location)
        {
            return 0.0f;
        }

        [CLSCompliant(false)]
        public static ushort Read(ref ushort location)
        {
            return (ushort)0;
        }

        [CLSCompliant(false)]
        public static uint Read(ref uint location)
        {
            return 0U;
        }

        [SecuritySafeCritical]
        [CLSCompliant(false)]
        public static ulong Read(ref ulong location)
        {
            return 0UL;
        }

        [CLSCompliant(false)]
        public static UIntPtr Read(ref UIntPtr location)
        {
            return new UIntPtr();
        }

        [SecuritySafeCritical]
        public static T Read<T>(ref T location) where T : class
        {
            return default(T);
        }

        public static void Write(ref bool location, bool value)
        {
        }

        public static void Write(ref byte location, byte value)
        {
        }

        public static void Write(ref double location, double value)
        {
        }

        public static void Write(ref short location, short value)
        {
        }

        public static void Write(ref int location, int value)
        {
        }

        public static void Write(ref long location, long value)
        {
        }

        public static void Write(ref IntPtr location, IntPtr value)
        {
        }

        [CLSCompliant(false)]
        public static void Write(ref sbyte location, sbyte value)
        {
        }

        public static void Write(ref float location, float value)
        {
        }

        [CLSCompliant(false)]
        public static void Write(ref ushort location, ushort value)
        {
        }

        [CLSCompliant(false)]
        public static void Write(ref uint location, uint value)
        {
        }

        [CLSCompliant(false)]
        [SecuritySafeCritical]
        public static void Write(ref ulong location, ulong value)
        {
        }

        [CLSCompliant(false)]
        public static void Write(ref UIntPtr location, UIntPtr value)
        {
        }

        [SecuritySafeCritical]
        public static void Write<T>(ref T location, T value) where T : class
        {
        }
    }
}
