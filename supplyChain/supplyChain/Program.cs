using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supplyChain
{
    class Program
    {
        static void Main(string[] args)
        {
            supply order1 = new supply();
            order1.SiparisNo = 1001;
            order1.UrunId = 10;
            order1.ImalatMaliyeti=2750;
            order1.TasimaMaliyeti = 550;
            order1.DepoMaliyeti = 990;
            order1.calcUrunToplamMaliyeti();
            Console.WriteLine(" Siparisi verilen urun toplam tutarı : {0}", order1.UrunToplamMaliyeti);
            
            Console.ReadLine();
        }
    }
}
