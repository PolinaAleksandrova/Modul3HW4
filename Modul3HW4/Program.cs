using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MathMethods mathMethods = new MathMethods();
            MathContainer mathContainer = new MathContainer();
            mathContainer.CounterIsFull += mathMethods.Sum;
            mathContainer.CounterIsFull += mathMethods.Sum;
            mathContainer.Multiply(8);
            mathContainer.Multiply(3);
            mathContainer.Multiply(5);
            mathContainer.Multiply(3);
            mathContainer.Multiply(5);
            mathContainer.Multiply(8);
            mathContainer.Multiply(8);
            mathContainer.Multiply(3);
            mathContainer.Multiply(5);
            mathContainer.Multiply(3);
            mathContainer.Multiply(5);
            mathContainer.Multiply(8);

            var source = new List<User>
            {
                new User { Id = 1, FirstName = "Ihor", LastName = "Serdiuk", Age = 27, BirthDate = DateTime.UtcNow.AddYears(-10) },
                new User { Id = 2, FirstName = "Taras", LastName = "Serdiuk", Age = 13, BirthDate = DateTime.UtcNow.AddYears(-11) },
                new User { Id = 3, FirstName = "Dmitry", LastName = "Serdiuk", Age = 11, BirthDate = DateTime.UtcNow.AddYears(-12) },
                new User { Id = 4, FirstName = "Georgiy", LastName = "Serdiuk", Age = 90, BirthDate = DateTime.UtcNow.AddYears(-13) },
                new User { Id = 5, FirstName = "Gennadiy", LastName = "Serdiuk", Age = 47, BirthDate = DateTime.UtcNow.AddYears(-14) },
                new User { Id = 6, FirstName = "Aleksey", LastName = "Kernes", Age = 21, BirthDate = DateTime.UtcNow.AddYears(-15) },
                new User { Id = 7, FirstName = "Petr", LastName = "Poroshenko", Age = 12, BirthDate = DateTime.UtcNow.AddYears(-16) },
                new User { Id = 8, FirstName = "Gennadiy", LastName = "Serdiuk", Age = 2, BirthDate = DateTime.UtcNow.AddYears(-17) }
            };

            var notSerdiuk = source.FirstOrDefault();
            var isNull = source?.Any() == true;
            var selectNames = source.Select(item => item.FirstName);
            var selectLastNames = source.Select(item => item.LastName);
            var isAnyYounger27 = source.Any(item => item.Age > 27);
            var older13 = source.Where(item => item.Age > 13);
            var groupLastName = source.GroupBy(item => item.LastName);
            var lastUser = source.Last();
            var maxAge = source.Max(item => item.Age);
            var minAge = source.Min(item => item.Age);
            var averageAge = source.Average(item => item.Age);
        }
    }
}
