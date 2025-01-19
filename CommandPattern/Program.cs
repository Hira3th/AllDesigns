// See https://aka.ms/new-console-template for more information
using CommandPattern.Logic;

Console.WriteLine("Hello, Command!");

Light light = new Light();
TurnOnCommand turnOn = new TurnOnCommand(light);
TurnOffCommand turnOff = new TurnOffCommand(light);

RemoteControl remote = new RemoteControl();

remote.SetCommand(turnOn);
remote.PressButton();

remote.SetCommand(turnOff);
remote.PressButton();
remote.PressUndo();