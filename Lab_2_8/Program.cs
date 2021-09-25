using System;

namespace Lab_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(800, "Tom", "Microsoft", "Iphone", 2);
            invoice.Calculator();
        }
    }
    public class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        string article;
        int quantity;
        
        public Invoice(int Account, string Customer, string Provider, string Article, int Quantity)
        {
            account = Account;
            customer = Customer;
            provider = Provider;
            article = Article;
            quantity = Quantity;
        }

        public void Calculator()
        {
            int sumWithoutVAT = account * quantity;
            int VAT = sumWithoutVAT / 10;
            int sumWithVAT = sumWithoutVAT - VAT;
            Console.WriteLine($"Заказчик: {customer}, поставщик: {provider}, название товара: {article}, количество: {quantity}");
            Console.WriteLine($"Сумма заказа без учета НДС: {sumWithoutVAT}. Сумма заказа с учетом НДС: {sumWithVAT}");
        }
    }
}
