using System;
public class EventController
{
    public Action baseEvent;

    public void AddListener(Action listener)=> baseEvent += listener;//this is the subscription function
    
    public void RemoveListener(Action listener) => baseEvent -= listener;//this is the unsubscription function
    public void InvokeEvent() => baseEvent?.Invoke();// this is the invoking function
}
