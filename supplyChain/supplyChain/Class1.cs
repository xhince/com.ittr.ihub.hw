using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supplyChain
{
    class supply
    {
        private int siparisNo;
        private int urunId;
        private int urunAdet;
        private double urunDesi;
        private int tedarikciId;
        private int depoId;
        private double imalatMaliyeti;
        private double depoMaliyeti;
        private double tasimaMaliyeti;
        private double urunToplamMaliyeti;

        public int SiparisNo
        {
            get { return siparisNo; }
            set { siparisNo = value; }
        }

        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }

        public int UrunAdet
        {
            get { return urunAdet; }
            set { urunAdet = value; }
        }

        public double UrunDesi
        {
            get { return urunDesi; }
            set { urunDesi = value; }
        }

        public int TedarikciId
        {
            get { return tedarikciId; }
            set { tedarikciId = value; }
        }

        public int DepoId
        {
            get { return depoId; }
            set { depoId = value; }
        }

        public double ImalatMaliyeti
        {
            get { return imalatMaliyeti; }
            set { imalatMaliyeti = value; }
        }

        public double DepoMaliyeti
        {
            get { return depoMaliyeti; }
            set { depoMaliyeti = value; }
        }
         public double TasimaMaliyeti
        {
            get { return tasimaMaliyeti; }
            set { tasimaMaliyeti = value; }
        }
        public double UrunToplamMaliyeti
        {
            get { return urunToplamMaliyeti; }
            //set { urunToplamMaliyeti = value; }
        }
        public double calcUrunToplamMaliyeti()
        {
            
            this.urunToplamMaliyeti = this.imalatMaliyeti + this.tasimaMaliyeti + this.depoMaliyeti;
            return this.urunToplamMaliyeti;
        }
    }
}

