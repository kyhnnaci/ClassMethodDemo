using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class CustomerManager
    {
        public void EditCustomer(Customer Customer1)
        {
            Customer1.Id = 1;
            Console.WriteLine("İsim giriniz : ");
            Customer1.Name = Console.ReadLine();
            Console.WriteLine("Soyad giriniz : ");
            Customer1.Surname = Console.ReadLine();
            Console.WriteLine("Müşteri Numarası Giriniz : ");
            Customer1.CustromerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hesap Numarası Giriniz");
            Customer1.AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Başarıyla yenilendi, Yeni bilgiler : ");
            Console.WriteLine("\n");
            Console.WriteLine("Yeni Müşteri Id : " + Customer1.Id);
            Console.WriteLine("Yeni Müşteri adı : " + Customer1.Name);
            Console.WriteLine("Yeni Müşteri Soyadı : " + Customer1.Surname);
            Console.WriteLine("Yeni Müşteri Numarası : " + Customer1.CustromerNumber);
            Console.WriteLine("Yeni Müşteri Hesap No : " + Customer1.AccountNumber);

        }

        public void SearchCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Id : " + customer.Id);
            Console.WriteLine("Müşteri adı : " + customer.Name);
            Console.WriteLine("Müşteri Soyadı : " + customer.Surname);
            Console.WriteLine("Müşteri Numarası : " + customer.CustromerNumber);
            Console.WriteLine("Müşteri Hesap No : " + customer.AccountNumber);
        }
    }
}
