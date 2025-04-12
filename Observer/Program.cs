using Observer.Models;
using Observer.Logic;

Console.WriteLine("Hello, Observer!");

// Create the subject (the entity being observed)
Subject subject = new Subject();

// Create observers (entities that will react to changes in the subject)
Observer.Models.Observer observer1 = new Observer.Models.Observer("Observer 1");
Observer.Models.Observer observer2 = new Observer.Models.Observer("Observer 2");

// Attach observers to the subject
subject.Attach(observer1);
subject.Attach(observer2);

// Notify all attached observers of an update
subject.Notify("Update available");

// Detach one observer
subject.Detach(observer1);

// Notify remaining observers of another update
subject.Notify("Another update");

Console.ReadLine();