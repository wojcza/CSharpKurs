using System;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;
        static void Main(string[] args)
        {
            //   InstructionIf();
            //nstructionSwitch();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int a = 0; a < 2; a++)
            //    {
            //        Console.WriteLine("Wartość i: {0} oraz wartość a: {1}", i,a);
            //    }
            //}

            int i = 1;
            //while(i > 5)
            //{
            //    Console.WriteLine("Wartość i: {0}", i);
            //    i++;
            //}
            //do
            //{
            //    Console.WriteLine("Wartość i: {0}", i);
            //    i++;
            //}
            //while (i > 3);
            int[] tab = { 1, 2, 3, 5, 8, 12, 21 };
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void InstructionSwitch()
        {
            Console.WriteLine("Podaj imię: ");
            name = Console.ReadLine();

            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    Method3();
                    break;
                default:
                    Method4();
                    break;
            }
        }

        private static void InstructionIf()
        {
            Console.WriteLine("Podaj swój wiek: ");
            age = int.Parse(Console.ReadLine());

            string test = age > 18 ? "Pełnoletni" : "Dziecko";
            Console.WriteLine(test);

            Console.WriteLine("Podaj swoje imię: ");
            name = Console.ReadLine();

            if (age <= 10)
            {
                if (name == "Marcin")
                {
                    Method1();
                }
            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }
        }

        private static void Method4()
        {
            Console.WriteLine("Jesteś w metodzie 4");
        }

        private static void Method3()
        {
            Console.WriteLine("Jesteś w metodzie 3");
        }

        private static void Method2()
        {
            Console.WriteLine("Jesteś w medodzie 2");
        }

        private static void Method1()
        {
            Console.WriteLine("Jesteś w metodzie 1");
        }
    }
}
