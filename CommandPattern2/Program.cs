// See https://aka.ms/new-console-template for more information
using CommandPattern2.Logic;

Console.WriteLine("Hello, World!");

// The client code can parameterize an invoker with any commands.
Invoker invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hi!"));
Receiver receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();