using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }


        // Stan  (zmienne - pola)
        List<float> ratings; // = new List<float>();


        // Zachowania
        /// <summary>
        /// Dodawanie oceny do Dzienniczka
        /// </summary>
        /// <param name="rating">nowa ocena</param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Obliczamy średnią naszych ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();

            return avg;
        }
        /// <summary>
        /// pobieramy najwyższą ocenę
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        /// <summary>
        /// pobieramy najniższą ocenę
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
