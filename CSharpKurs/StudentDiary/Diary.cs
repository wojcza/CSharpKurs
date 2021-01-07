using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
         //   Count++;
        }


        // Stan  (zmienne - pola)
        private List<float> ratings; // = new List<float>();
                                     //public static float MinGrade = 0;
                                     //public static float MaxGrade = 10;
                                     // public static long Count = 0;

        public string Name;

        // Zachowania
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
        }
        public DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();
            return stats;
        }

        //public float CalculateAverage()
        //{
        //    float sum = 0, avg = 0;
        //    foreach (var rating in ratings)
        //    {
        //        sum += rating;
        //    }
        //    avg = sum / ratings.Count();
        //    return avg;
        //}
        //public float GiveMaxRating()
        //{
        //    return ratings.Max();
        //}
        //public float GiveMinRating()
        //{
        //    return ratings.Min();
        //}
    }
}
