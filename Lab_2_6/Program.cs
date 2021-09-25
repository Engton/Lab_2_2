using System;

namespace Lab_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter con = new Converter(27.6, 30.2, 0.3);
            con.ConvertUSD(15);
        }
    }

    public class Converter
    {
        double USD, EUR, RUB;
        double outputValue;

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public void ConvertUSD(double UAH)
        {
            double output = UAH / USD;
            Console.WriteLine(output);
        }

        public void ConvertFromUSD(double Usd)
        {
            double output = Usd * USD;
            Console.WriteLine(output);
        }

        public void ConvertEUR(double UAH)
        {
            double output = UAH / EUR;
            Console.WriteLine(output);
        }

        public void ConvertFromEUR(double Eur)
        {
            double output = Eur * EUR;
            Console.WriteLine(output);
        }

        public void ConvertRUB(double UAH)
        {
            double output = UAH / RUB;
            Console.WriteLine(output);
        }
        public void ConvertFromRUB(double Rub)
        {
            double output = Rub * RUB;
            Console.WriteLine(output);

        }
    }
}