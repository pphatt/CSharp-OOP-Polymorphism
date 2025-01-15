using CSharpOOPPolymorphism.Method_Overloading;
using CSharpOOPPolymorphism.Method_Overriding;

namespace CSharpOOPPolymorphism;

public class Program
{
    static void Main(string[] args)
    {
        // method overloading: same class, same function name but different in parameter.
        MethodOverloading methodOverloading = new MethodOverloading(100);
        methodOverloading.Transact(50);
        methodOverloading.Transact(80.1m);

        Console.WriteLine(methodOverloading.ShowBalance());

        // method overriding: different class, inherit from the base class that contain the virtual method, override them in the children class.
        Control control;

        control = new TV();
        control.PowerOn();

        control = new AC();
        control.PowerOn();
        control.PowerOff();
    }
}
