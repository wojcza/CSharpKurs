﻿using System;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(3.5f);
            //diary.AddRating(5.4f);
            //diary.AddRating(8.4f);

            //DiaryStatistics stats = diary.ComputeStatistics();
            //WriteResult("Average", stats.AverageGrade, 3, 5, 7, 8, 9);
            //WriteResult("Max", (int)stats.MaxGrade);
            //WriteResult("Min", (long)stats.MinGrade);
            //WriteResult("Min", stats.MinGrade, 1);
            diary.NameChanged += (OnNameChanged);
            diary.NameChanged += (OnNameChanged2);
            diary.NameChanged += (OnNameChanged3);
            diary.NameChanged += (OnNameChanged4);
            diary.NameChanged += (OnNameChanged4);
            diary.NameChanged += (OnNameChanged4);
            diary.NameChanged += (OnNameChanged4);
            diary.NameChanged -= (OnNameChanged4);
            diary.NameChanged -= (OnNameChanged4);
            diary.NameChanged -= (OnNameChanged4);


            diary.Name = "Dzienniczek Marcina";
            diary.Name = "Jacek Hej";
            //diary.Name = null;
            Console.WriteLine(diary.Name);
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }
        //private static void OnNameChanged2(string existingName, string newName)
        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***************");
        }
        private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Hello");
        }
        private static void OnNameChanged4(object sender, NameChangedEventArgs argse)
        {
            Console.WriteLine("++++++++++");
        }
        //static void WriteResult(string description, params float[] result)
        //{
        //    Console.WriteLine(description + ": " + result[0] + "  " + result[4]);
        //}

        //static void WriteResult(string description, int result)
        //{
        //    Console.WriteLine(description + ": " + result);
        //}

        //static void WriteResult(string description, long result)
        //{
        //    Console.WriteLine(description + ": " + result);
        //}

        //static void WriteResult(string description, float result, long test)
        //{
        //    Console.WriteLine($"{description}: {result:C1}: {2}: {3}: {4}: {5} ");
        //}
    }
}
