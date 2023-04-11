using System;

namespace tryEventHandler;

class Program
{
    static void Main()
    {
        var video_encoder = new VideoEncoder(); // publisher
        var videoo = new Video() {VideoName = "Video 1"}; // subscriber
        var MailService = new MailService(); // subscriber

        video_encoder.VideoEncoded += MailService.OnVideoEncoded;

        video_encoder.Encode(videoo);
    }
}

/*
public class MailService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("Mail Service: Sending an Email...");
    }
}
*/

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("haloooo!");
        Publisher publisher1 = new();
        Subscribers subscriber1 = new();
        subscriber1.MethodA(publisher1);
    

    }
}

public class Publisher
{
    public delegate void MyFirstDelegate(string msg);
    public event MyFirstDelegate? MyFirstEvent;

    public void Action()
    {
        Console.WriteLine("Proses berjalan....");
        InvokeMessage("Done by Gilang");
    }

    public virtual void InvokeMessage(string msg)
    {
        MyFirstEvent?.Invoke(msg);
    }
}

public class Subscribers
{
    public void MethodA(Publisher input)
    {
        input.MyFirstEvent += MyEventHandler;
    }

    public void MyEventHandler(string msg)
    {
        Console.WriteLine("message: "+msg);
    }
}
*/