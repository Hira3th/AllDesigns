// See https://aka.ms/new-console-template for more information
using Observer.Models;

Console.WriteLine("Hello, Observer!");

Subject subject = new Subject();


Observer.Models.Observer observer1 = new Observer.Models.Observer("Observer 1");
Observer.Models.Observer observer2 = new Observer.Models.Observer("Observer 2");

subject.Attach((IObserver)observer1);
subject.Attach((IObserver)observer2);

subject.Notify("Update available");

subject.Detach((IObserver)observer1);

subject.Notify("Another update");