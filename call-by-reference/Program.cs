﻿using System;
class CallByReferenceApp
{
    static void Swap(ref int x, ref int y)
    {
        int temp;
        temp = x; x = y; y = temp;
        Console.WriteLine(" Swap: x = {0}, y = {1}", x, y);
    }
    public static void Main()
    {
        int x = 1, y = 2; // x, y 값 지정
        Console.WriteLine("Before: x = {0}, y = {1}", x, y);
        Swap(ref x, ref y);
        Console.WriteLine(" After: x = {0}, y = {1}", x, y);
    }
}