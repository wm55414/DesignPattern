namespace DecoratorPattern;
using System;

internal class ConcreteComponent: Component
{
    public override void Operation()
    {
        Console.WriteLine("具體的操作");
    }
}
