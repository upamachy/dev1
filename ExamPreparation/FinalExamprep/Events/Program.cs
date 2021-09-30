using System;

namespace Events
{
    class Program
    {
        delegate void Receive(string recepient,string message);
        static event Receive Subscribe;
        //static event Action <string,string> Subscribe;

        static void Main(string[] args)
        {
            Subscribe += SMS_Subscriber;
            Subscribe += Email_Subscriber;

            Subscribe.Invoke("Upama", "Hello from c#");
        }

        private static void SMS_Subscriber(string recepient, string message)
        {
            Console.WriteLine($"Send SMS to:{recepient} and message:{message}");
        }

        private static void Email_Subscriber(string recepient, string message)
        {
            Console.WriteLine($"Send mail to:{recepient} and message:{message}");
        }
    }
}
