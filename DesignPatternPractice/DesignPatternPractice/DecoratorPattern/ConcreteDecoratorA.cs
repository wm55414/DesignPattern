namespace DecoratorPattern
{
    internal class ConcreteDecoratorA:Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("裝飾A");
        }
    }
}
