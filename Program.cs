using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            int count = 4;
            var totalPrice = 20.45f;
            var character = 'B';
            string firtname = "Mosh";
            bool works = false;


            Console.WriteLine(number);

            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firtname);
            Console.WriteLine(works);


            Console.WriteLine("{0} {1} ", byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue , float.MaxValue);
        }
    }
}

