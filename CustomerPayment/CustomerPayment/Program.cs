using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    
    class Program
    {
        static void Main(string[] args)
        {
            CustomerSalary customer1 = new CustomerSalary();
            customer1.BrutMaas = 2029.5;
            customer1.FazlaMesaiSaati = 3;
            customer1.odenecekTutarHesapla();
            Console.WriteLine("Brut Maas : {0}", customer1.BrutMaas);
            Console.WriteLine("Mesai Ucreti : {0}", customer1.FazlaMesaiUcreti);
            Console.WriteLine("Toplam Vergi : {0}", customer1.GelirVergisi);
            Console.WriteLine("Net Maas : {0}", customer1.NetMaas);
            Console.WriteLine("Odenecek Tutar : {0}", customer1.OdenecekTutar);
            Console.ReadLine();
        }
    }

 
}
