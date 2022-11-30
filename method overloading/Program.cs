using System;
using System.CodeDom.Compiler;

class MethodOverloadingApp
{
    void SomeThing()
    {
        Console.WriteLine("SomeThing() is called.");
    }
    void SomeThing(int i)
    {
        Console.WriteLine("SomeThing(int) is called.");
    }
    void SomeThing(int i, int j)
    {
        Console.WriteLine("SomeThing(int,int) is called.");
    }
    void SomeThing(double d)
    {
        Console.WriteLine("SomeThing(double) is called.");
    }
    // 객체 생성 후 메소드 접
    public static void Main()
    {
        MethodOverloadingApp obj = new MethodOverloadingApp();
        obj.SomeThing(); obj.SomeThing(526);
        obj.SomeThing(54, 526); obj.SomeThing(5.26);
    }
}
