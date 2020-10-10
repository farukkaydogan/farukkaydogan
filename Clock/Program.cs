using System;

abstract class A
{ abstract public int ozellik { set; get; } }
class B : A
{
    override public int ozellik
    {
        get { return 100; }
        set { Console.WriteLine("Bu bir denemedir"); }
    }
    static void Main()
    {
        B nesne = new B();
        Console.WriteLine(nesne.ozellik); nesne.ozellik = 200;
    }
}