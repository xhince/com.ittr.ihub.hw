using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    class CustomerSalary
    {
        private double brutMaas;
        private double netMaas;
        private double odenecekTutar;
        private bool medenihal;
        private int cocuksayisi;
        private double sigortaPrimi;
        private double issizlikPrimi;
        private double gelirVergisi;
        private double gelirVergisiMatrahi;
        private double fazlaMesaiBirimUcreti = 40;
        private int fazlaMesaiSaati;
        private double fazlaMesaiUcreti;
        

        public double BrutMaas
        {
            get { return brutMaas; }
            set { brutMaas = value; }
        }

        public double NetMaas
        {
            get { return netMaas; }
            //set { netMaas = value; }
        }

        public double OdenecekTutar
        {
            get { return odenecekTutar; }
            //set { odenecekTutar = value; }
        }

        public bool Medenihal
        {
            get { return medenihal; }
            set { medenihal = value; }
        }

        public int Cocuksayisi
        {
            get { return cocuksayisi; }
            set { cocuksayisi = value; }
        }

        public double SigortaPrimi
        {
            get { return sigortaPrimi; }
            //set { sigortaPrimi = value; }
        }

        public double İssizlikPrimi
        {
            get { return issizlikPrimi; }
            //set { issizlikPrimi = value; }
        }

        public double GelirVergisi
        {
            get { return gelirVergisi; }
            //set { gelirVergisi = value; }
        }

        public double GelirVergisiMatrahi
        {
            get { return gelirVergisiMatrahi; }
            //set { gelirVergisiMatrahi = value; }
        }

        public double FazlaMesaiBirimUcreti
        {
            get { return fazlaMesaiBirimUcreti; }
            set { fazlaMesaiBirimUcreti = value; }
        }

        public int FazlaMesaiSaati
        {
            get { return fazlaMesaiSaati; }
            set { fazlaMesaiSaati = value; }
        }

        public double FazlaMesaiUcreti
        {
            get { return fazlaMesaiUcreti; }
        }

        private double mesaiUcretiHesapla()
        {
            this.fazlaMesaiUcreti = this.fazlaMesaiBirimUcreti * this.fazlaMesaiSaati;
            return this.fazlaMesaiUcreti;
        }

        private double vergiMatrahiHesapla()
        {
            this.issizlikPrimi = this.brutMaas * 0.01;
            this.sigortaPrimi = this.brutMaas * 0.14;
            this.gelirVergisiMatrahi = this.brutMaas - (this.issizlikPrimi + this.sigortaPrimi);
            return gelirVergisiMatrahi;
        }

        private double gelirVergisiHesapla()
        {
            vergiMatrahiHesapla();
            this.gelirVergisi = this.gelirVergisiMatrahi * 0.15;
            return this.gelirVergisi;
        }

        private double netMaasHesapla()
        {
            gelirVergisiHesapla();
            double damgaPuluVergisi = this.brutMaas * 0.00759;
            this.netMaas = this.brutMaas - (this.gelirVergisi + this.issizlikPrimi + this.sigortaPrimi+ damgaPuluVergisi);
            return this.netMaas;
        }

        public double odenecekTutarHesapla()
        {
            netMaasHesapla();
            mesaiUcretiHesapla();
            this.odenecekTutar = this.netMaas + this.fazlaMesaiUcreti;
            return this.odenecekTutar;
        }

    }
}
