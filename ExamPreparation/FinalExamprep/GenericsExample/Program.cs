using System;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book { Isbn="1234",Title= "Fiction"};

            //var number = new GenericList<int>();
            //number.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());

            //var dictionary2 = new GenericDictionary<string, Product>();
            //dictionary2.Add("1235", new Product());

            var number = new Nullable<int>(5);
            Console.WriteLine("Has value?"+number.HasValue);
            Console.WriteLine("value is: "+number.GetValueOrDefault());

            var number2 = new Nullable<int>();
            Console.WriteLine("Has value?" + number2.HasValue);
            Console.WriteLine("value is: " + number2.GetValueOrDefault());
        }
    }
}
