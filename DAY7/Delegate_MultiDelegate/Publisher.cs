// berisi delegate
namespace MultiDelegate
{
    public class MyEventPublisher
    {
        public delegate void MyDelegate(string message);
        //public MyDelegate? MyEvent;
        public event MyDelegate? MyEvent;
        public void DoSomething()
        {
            Console.WriteLine("Doing some interest...");
            OnMyEvent("Hello, World!");
        }

        protected virtual void OnMyEvent(string message)
        {
            MyEvent?.Invoke(message);
        }
    }
}