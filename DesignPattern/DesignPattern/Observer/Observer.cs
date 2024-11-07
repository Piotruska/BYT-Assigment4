﻿// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName = userName;
        private string _availability;
        public void Update(string availability)
        {
            _availability = availability;
        }

        public void AddSubscriber(Subject subject)
        {
            subject.RegisterObserver(this);
        }
        
        public void RemoveSubscriber(Subject subject)
        {
            subject.RemoveObserver(this);
        }
        // Your code goes here... make sure to add this features:
        //1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject)
        //2. Creating the Observer
        //3. Registering the Observer with the Subject
        //4. Removing the Observer from the Subject
        //5. Observer will get a notification from the Subject using the following Method
    }
}
