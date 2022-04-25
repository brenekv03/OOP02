using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    class Atlet
    {
        private int unava=0;
        private string prijmeni;
        public string Jmeno { get; }
        public string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                //string s = value;
                //možná tam má bejt string :)♥
                value = char.ToUpper(value[0]) + value.Substring(1);
                prijmeni = value;
            }
        }
            public Atlet(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        public int GetUnava()
        {
            return unava;
        }
        public void Behej(int kilometr)
        {
            if(unava <= 200 && (unava + kilometr * 10) <=200) 
            {
                unava += kilometr * 10;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sem utahanej :(, smolík");
            }
        }
        public void Spi(int dobaSpanku)
        {
            if ((unava - dobaSpanku * 100) < 0) unava = 0;
            else unava -= dobaSpanku * 100;
        }

    }
}
