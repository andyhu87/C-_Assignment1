using System;

class Program
{
    static void Main()
    {
        // 1
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "Type", "Bytes", "Minimum Value", "Maximum Value");
        Console.WriteLine("");
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0,-9}{1,-9}{2,-25}{3,-25}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        Console.WriteLine("");


        // 2
        Console.WriteLine("Input # of Century(ies): ");
        int century = int.Parse(Console.ReadLine());

        long years = century * 100;
        long days = years * 365;
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        long microseconds = milliseconds * 1000;
        long nanoseconds = microseconds * 1000;

        Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} " +
            $"hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = " +
            $"{microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}