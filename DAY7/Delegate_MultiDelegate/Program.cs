// See https://aka.ms/new-console-template for more information
using System;

namespace MultiDelegate;

class Program
{
    public static void Main()
    {
        // membuat publisher dari public class MyEventPublisher dengan nama "publisher"
        MyEventPublisher publisher = new(); 

        // membuat subscriber dari public class MyEventSubscriber1 dengan nama "subscriber1"
        MyEventSubscriber1 subscriber1 = new();

        // membuat subscriber dari public class MyEventSubscriber2 dengan nama "subscriber2"
        MyEventSubscriber2 subscriber2 = new();
    
        // memasukkan subscriber1 ke publisher dengan publisher.MyEvent
        publisher.MyEvent += subscriber1.MethodA1;
        publisher.MyEvent += subscriber1.MethodA2;
        publisher.MyEvent += subscriber2.MethodB1;
        publisher.MyEvent += subscriber2.MethodB2;
        int yuhu = 8;
        publisher.DoSomething();
    }
}
