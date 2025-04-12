// See https://aka.ms/new-console-template for more information
using System.Windows.Input;
using CommandPattern.Logic;

Console.WriteLine("Hello, Command!");

Light light = new Light();
ICommand command = new ICommand();

RemoteControl remote = new RemoteControl();

command = new TurnOnCommand(light);
remote.SetCommand(command);
remote.PressButton();

command = new TurnOffCommand(light);
remote.SetCommand(command);
remote.PressButton();
remote.PressUndo();