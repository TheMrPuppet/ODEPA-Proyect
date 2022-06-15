using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ODEPA_.Model
{
    public class Productor
    {
        private int prut;
        private string prutid;
        private string pnombre;
        private string pcorreo;
        private string padress;

        public Productor() { }
        public Productor(int prut, string prutid, string pnombre, string pcorreo, string padress)
        {
            this.Prut = prut;
            this.Prutid = prutid;
            this.Pnombre = pnombre;
            this.Pcorreo = pcorreo;
            this.Padress = padress;
        }

        public int Prut { get => prut; set => prut = value; }
        public string Prutid { get => prutid; set => prutid = value; }
        public string Pnombre { get => pnombre; set => pnombre = value; }
        public string Pcorreo { get => pcorreo; set => pcorreo = value; }
        public string Padress { get => padress; set => padress = value; }
    }
}
