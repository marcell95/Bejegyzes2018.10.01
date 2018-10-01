using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime szerkesztve;
        //DateTime letrejott = new DateTime(2018, 10, 1);
        private DateTime letrejott;

        public void Like() {
            this.likeok++;

        }

        public void Kiir() {
            //Console.WriteLine(this.szerzo + " - " + this.likeok + " - " + letrejott + "\nSzerkesztve: " + this.szerkesztve + "\n" + this.tartalom);
            Console.WriteLine(this.Szerzo + " - " + this.Likeok + " - " + this.Letrejott + "\nSzerkesztve: " + this.Szerkesztve + "\n" + this.Tartalom);

        }

        public string Szerzo
        {
            get
            {
                return szerzo;
            }
            
        }

        public string Tartalom
        {
            get
            {
                return tartalom;
            }

            set
            {
                tartalom = value;
                szerkesztve = DateTime.Now;
            }
        }

        public int Likeok
        {
            get
            {
                return likeok;
            }
            
        }

        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }
            
        }

        public DateTime Szerkesztve
        {
            get
            {
                return szerkesztve;
            }
            
        }

        public Bejegyzes(string szerzo, string tartalom, int likeok)
        {
            this.szerzo = szerzo;
            this.Tartalom = tartalom;
            this.likeok = likeok;
            this.szerkesztve = DateTime.Now;
            this.letrejott = DateTime.Now;
        }
    }
}
