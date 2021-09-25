using System;

namespace Lab_2_7
{
    class Program
    {

        static void Main(string[] args)
        {
            string a, b, c, d;
            string position = null, name = null, lastname = null;
            int experience = new int();
            int x = 0;

            switch (x)
            {
                case 0:
                    {
                        Console.WriteLine("Введите имя пользователя: ");
                        a = Console.ReadLine();

                        if (!string.IsNullOrEmpty(a))
                        {
                            name = a;
                            goto case 1;
                        }
                        else goto case 0;
                    }
                case 1:
                    {
                        Console.WriteLine("Введите фамилию пользователя: ");
                        b = Console.ReadLine();

                        if (!string.IsNullOrEmpty(b))
                        {
                            lastname = b;
                            goto case 2;
                        }
                        else goto case 0;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите ваш стаж в целых годах: ");
                        c = Console.ReadLine();

                        if (int.TryParse(c, out int result))
                        {
                            experience = Int32.Parse(c);
                            goto case 3;
                        }
                        else goto case 1;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите вашу должность: junior, middle, senior");
                        d = Console.ReadLine();
                        if (d == "junior" || d == "middle" || d == "senior")
                        {
                            position = d;
                            break;
                        }
                        else goto case 2;
                    }
            }
            Employee employee = new Employee(name, lastname, Convert.ToString(experience), position);
            employee.SalaryCalculator();
        }

    }

    public class Employee

    {

        string FirstName, LastName, Experience, Position;
        double salaryInt = 100;
        readonly double taxes = 0.9;
        double positionSurcharge = new double();
        double experienceSurcharge = new double();

        public Employee(string firstName, string lastName, string experience, string position)
        {
            Experience = experience;

            Position = position;

            FirstName = firstName;

            LastName = lastName;

            if (position == "junior")
            {
                positionSurcharge = 1;
            }
            else if (position == "middle")
            {
                positionSurcharge = 1.05;
            }
            else if (position == "senior")
            {
                positionSurcharge = 1.10;
            }

            if (Int32.Parse(experience) <= 10)
            {
                experienceSurcharge = 1;
            }
            else if (Int32.Parse(experience) > 10)
            {
                experienceSurcharge = 1.15;
            }
        }

        public void SalaryCalculator()
        {
            double salary = salaryInt * positionSurcharge * experienceSurcharge;
            salaryInt = salaryInt * positionSurcharge * experienceSurcharge * taxes;
            double ofTaxes = salary - salaryInt;

            Console.WriteLine($"Имя: {FirstName}, фамилия: {LastName}, должность: {Position}, стаж работы: {Experience}. Заработная плата с учетом налога: {salaryInt}. Ушло на налог: {ofTaxes}.");
        }
    }
}
