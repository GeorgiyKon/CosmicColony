using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("math_operations.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void add(float a, float b);

    [DllImport("math_operations.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void subtract(float a, float b);

    static void Main()
    {
        add(5.0f, 3.0f);
        subtract(5.0f, 3.0f);
    }
}
