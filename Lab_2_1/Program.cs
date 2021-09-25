using System;

namespace Lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress1 = new Adress() { index = "12345", country = "Ukraine", city = "Kyiv", street = "Lobachevskogo", house = "23", apartment = "111" };
            Console.WriteLine($"{adress1.index}, {adress1.country}, {adress1.city}, {adress1.street}, {adress1.house}, {adress1.apartment}");
        }
    }

    public class Adress
    {
        public string index, country, city, street, house, apartment;

        public Adress()
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
        private protected static string Index { get; set; }
        private protected static string Country { get; set; }
        private protected static string City { get; set; }
        private protected static string Street { get; set; }
        private protected static string House { get; set; }
        private protected static string Apartment { get; set; }
    }
}