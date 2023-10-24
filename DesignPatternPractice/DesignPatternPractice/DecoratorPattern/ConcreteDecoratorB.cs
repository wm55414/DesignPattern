namespace DecoratorPattern
{
    internal class ConcreteDecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("裝飾B");
        }
        public void AddedBehavior()
        {
            
        }
    }
}
