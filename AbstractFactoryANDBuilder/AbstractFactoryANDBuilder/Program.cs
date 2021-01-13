using System;

namespace AbstractFactoryANDBuilder
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Part 1");
            string input = "Hello World";
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run(input);

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run(input);



            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            Console.WriteLine("Part 2");
            director.Construct(b1);
            Product p1 = new Product();
            p1.input = input;
            p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = new Product();
            p2.input = input;
            p2 = b2.GetResult();
            p2.Show();

        }
    }
}

