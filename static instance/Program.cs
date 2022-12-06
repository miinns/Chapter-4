using System;
public class StaticVsInstanceApp
{
    int instanceVariable; // private : default
    static int staticVariable;
    public static void Main()
    {
        
        StaticVsInstanceApp obj = new StaticVsInstanceApp();
        obj.instanceVariable = 10;
                                  
        StaticVsInstanceApp.staticVariable = 20;
                                            
        Console.WriteLine("instance variable={0}, static variable={1}",
        obj.instanceVariable, StaticVsInstanceApp.staticVariable);
    }
}
