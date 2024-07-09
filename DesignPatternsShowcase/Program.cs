using System;
using System.ComponentModel.Design.Serialization;
using System.ComponentModel;
using System.Runtime.InteropServices.JavaScript;
using System.Windows.Input;

namespace DesignPatternsShowcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns Showcase");

            // Singleton Pattern
            var logger = Logger.Instance;
            logger.Log("Singleton Pattern Initialized");

            // Factory Pattern
            var shapeFactory = new ShapeFactory();
            var circle = shapeFactory.CreateShape("Circle");
            var square = shapeFactory.CreateShape("Square");
            circle.Draw();
            square.Draw();

            // Strategy Pattern
            var context = new Context(new ConcreteStrategyA());
            context.ExecuteStrategy();
            context.SetStrategy(new ConcreteStrategyB());
            context.ExecuteStrategy();

            // Observer Pattern
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();
            subject.Attach(observerA);
            subject.Attach(observerB);
            subject.Notify();

            // Decorator Pattern
            IComponent component = new ConcreteComponent();
            component = new ConcreteDecoratorA(component);
            component = new ConcreteDecoratorB(component);
            component.Operation();

            // Adapter Pattern
            ITarget target = new Adapter();
            target.Request();

            // Facade Pattern
            var facade = new Facade();
            facade.Operation();

            // Proxy Pattern
            ISubject proxy = new Proxy();
            proxy.Request();

            // Command Pattern
            var receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            var invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Chain of Responsibility Pattern
            var handler1 = new ConcreteHandler1();
            var handler2 = new ConcreteHandler2();
            handler1.SetNext(handler2);
            handler1.HandleRequest(1);
            handler1.HandleRequest(2);

            // Template Method Pattern
            AbstractClass abstractClass = new ConcreteClassA();
            abstractClass.TemplateMethod();
            abstractClass = new ConcreteClassB();
            abstractClass.TemplateMethod();

            // State Pattern
            var contextState = new ContextState(new ConcreteStateA());
            contextState.Request();
            contextState.Request();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
