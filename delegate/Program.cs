﻿using System;
delegate void DelegateOne();
delegate void DelegateTwo(int i);
class DelegateClass
{
    public void MethodA()
    {
        Console.WriteLine("In the DelegateClass.MethodA ...");
    }
    public void MethodB(int i)
    {
        Console.WriteLine("DelegateClass.MethodB, i = " + i);
    }
}
class DelegateCallApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass();
        DelegateOne d1 = new DelegateOne(obj.MethodA);
        DelegateTwo d2 = new DelegateTwo(obj.MethodB); 
        d1(); 
        d2(10); 
    }
}