namespace CSharpOOPPolymorphism.Method_Overriding;

public class Control
{
    public virtual void PowerOn()
    {
        Console.WriteLine("This machine is Powered On");
    }

    public virtual void PowerOff() 
    { 
        Console.WriteLine("This machine is Powered On"); 
    }
}

public class TV : Control
{
    public override void PowerOn()
    {
        Console.WriteLine("TV is Powered On");
    }

    public override void PowerOff()
    {
        Console.WriteLine("TV is Powered Off");
    }
}

public class AC : Control
{
    public override void PowerOn() 
    {
        Console.WriteLine("AC is Powered On");
    }

    public override void PowerOff()
    {
        Console.WriteLine("AC is Powered Off");
    }
}
