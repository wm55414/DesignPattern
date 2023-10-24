namespace DesignPatternPractice;
using System;
using DecoratorPattern;
public class MainProgram
{
    public static void Main(String[] args)
    {
        ConcreteComponent c = new ConcreteComponent();
        ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
        ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();
        decoratorA.SetComponent(c);
        decoratorB.SetComponent(decoratorA);
        decoratorB.Operation();
    }
}