// berisi method
namespace MultiDelegate
{
    public class MyEventSubscriber1
    {
        public void MethodA1(string message)
        {   
            //menambahkan subscriber1 ke publisher
            
            Console.WriteLine("memanggil class MyEventSubscriber1 methodA1 with message: " + message );
            Thread.Sleep(500);
        }

        public void MethodA2(string message)
        {
            Console.WriteLine("memanggil class MyEventSubscriber1 methodA2 with message: " + message );
            Thread.Sleep(500);

        }
    }

    public class MyEventSubscriber2
    {
        public void MethodB1(string message)
        {
            Console.WriteLine("memanggil class MyEventSubscriber2 methodB1 with message: " + message );
            Thread.Sleep(500);
        }

        public void MethodB2(string message)
        {
            Console.WriteLine("memanggil class MyEventSubscriber2 methodB2 with message: " + message );
            Thread.Sleep(500);
        }
    }
}