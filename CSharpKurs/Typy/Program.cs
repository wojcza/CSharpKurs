using System;

namespace Typy
{
    class Program
    {
        //static void GiveName(ref Diary diary)
        //{
        //    diary = new Diary();
        //    diary.Name = "Nowy Dzienniczek Marcina";
        //}

        //static int IncrementNumber(int number)
        //{
        //    number = 42;
        //    return number;
        //}
        static void Main(string[] args)
        //{
        //    //PassByValueAndRef();

        //    // Immutable();
        //    Arrays();
        //}

        //private static void Arrays()
        //{
        //    float[] ratings;
        //    ratings = new float[5];

        //    AddRatings(ratings);


        //    foreach (var rating in ratings)
        //    {
        //        Console.WriteLine(rating);
        //    }
        //}

        //private static void AddRatings(float[] ratings)
        //{
        //    if (ratings.Length >= 4)
        //    {
        //        ratings[0] = 4.2f;
        //        ratings[1] = 6.7f;
        //        ratings[2] = 3f;
        //        ratings[3] = 8.5f;
        //        ratings[4] = 4.4f;
        //    }
        //}

        //private static void Immutable()
        //{
        //    string name = "   Marcin    ";
        //    name = name.Trim();
        //    Console.WriteLine(name);

        //    DateTime date = new DateTime(2015, 3, 10);
        //    date = date.AddHours(48);
        //    Console.WriteLine(date);
        //}


        //string name1 = "  Marcin  ";
        //string name2 = "marcin";

        //bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
        //Console.WriteLine(areEqual);
        {
            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);
            diary.AddRating(1.2f);
            diary.AddRating(9.6f);

            //Diary diary2 = new Diary();
            //Diary diary3 = new Diary();
            //Diary diary4 = new Diary();
            //Diary diary5 = new Diary();
            //Diary diary6 = new Diary();
            //Console.WriteLine(Diary.Count);

            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("Średnia Twoich ocen to: " + stats.AverageGrade);
            Console.WriteLine("Najwyższa ocena to: " + stats.MaxGrade);
            Console.WriteLine("Najniższa ocena to: " + stats.MinGrade);
            Console.ReadKey();

            Diary diary2 = new Diary();
            diary2.AddRating(5);
            diary2.AddRating(2.5f);
            diary2.AddRating(3.7f);
            diary2.AddRating(4.2f);
            diary2.AddRating(7.6f);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("Średnia Twoich ocen to: " + stats.AverageGrade);
            Console.WriteLine("Najwyższa ocena to: " + stats.MaxGrade);
            Console.WriteLine("Najniższa ocena to: " + stats.MinGrade);
            Console.ReadKey();

            //SpeechSynthesizer synt = new SpeechSynthesizer();
            //synt.Speak("Cześć Beatka. Jak się czujesz?. Czego tu");

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();
        }
    }
        //    for (; ; )
        //    {
        //        Console.WriteLine("Podaj ocenę z zakresu 1 - 10. Jeśli chcesz zatryzmać wprowadź liczbę 11");

        //        float rating;
        //        bool result = float.TryParse(Console.ReadLine(), out rating);

        //        if (rating == 11)
        //        {
        //            break;
        //        }

        //        if (result)
        //        {
        //            if (rating > 0 && rating <= 10)
        //            {
        //                diary.AddRating(rating);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Niepoprawna liczba, podaj z zakresu 1 - 10");
        //            }
        //        }

        //    }

        //    Console.WriteLine("Średnia Twoich ocen to: " + diary.CalculateAverage());
        //    Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
        //    Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
        //    Console.ReadKey();
        //}
        //Diary diary2 = new Diary();
        //Diary diary3 = new Diary();
        //Diary diary4 = new Diary();




    //    private static void PassByValueAndRef()
    //    {
    //        Diary d1 = new Diary();
    //        Diary d2 = d1;

    //        GiveName(ref d2);

    //        Console.WriteLine(d2.Name);

    //        int x1 = 0;
    //        x1 = IncrementNumber(x1);

    //        Console.WriteLine(x1);
    //    }
    //}
}
