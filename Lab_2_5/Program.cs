using System;

namespace Lab_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Age = "15", FirstName = "Alex", LastName = "Garrison" };
            Console.WriteLine($"Имя: {user.FirstName}, фамилия: {user.LastName}, возраст: {user.Age}. Дата заполнения анкеты: {user.creationDate}.");
            Console.ReadKey();
        }
    }
    class User
    {
        public readonly string creationDate;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public User()
        {
            creationDate = DateTime.Now.ToString();
        }
    }
}
