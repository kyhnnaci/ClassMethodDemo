using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer x = new Customer();
            x.Id = 1;
            x.Name = "Kayhan";
            x.Surname = "Başaran";
            x.CustromerNumber = 12345;
            x.AccountNumber = 6789;

            Customer y = new Customer();
            y.Id = 2;
            y.Name = "Ali";
            y.Surname = "Junior";
            y.CustromerNumber = 234230;
            y.AccountNumber = 897394;

            Customer[] customers = new Customer[] { x, y };


            CustomerManager customer = new CustomerManager();

            Console.WriteLine("Müşteri sorgulamak için 1'e, Müşteri Düzenlemek için 2'ye basınız, Müşteri Listelemek için 3'e basınız");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                customer.SearchCustomer(x);
            }
            else if (Convert.ToInt32(Console.ReadLine()) == 2)
            {
                customer.EditCustomer(x);
            }
            else
            {
                foreach (var item in customers)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Surname);
                    Console.WriteLine(item.CustromerNumber);
                    Console.WriteLine(item.AccountNumber);
                    Console.WriteLine("------------------------------------------");
                }
            }
        }
    }
}
