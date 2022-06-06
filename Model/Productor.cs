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
        private Bitmap pimage;
        private string padress;
        private float latitude;
        private float longitude;

        public Productor() { }
        public Productor(int prut, string prutid, string pnombre, string pcorreo, Bitmap pimage, string padress, float latitude, float longitude)
        {
            this.Prut = prut;
            this.Prutid = prutid;
            this.Pnombre = pnombre;
            this.Pcorreo = pcorreo;
            this.Pimage = pimage;
            this.Padress = padress;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public int Prut { get => prut; set => prut = value; }
        public string Prutid { get => prutid; set => prutid = value; }
        public string Pnombre { get => pnombre; set => pnombre = value; }
        public string Pcorreo { get => pcorreo; set => pcorreo = value; }
        public Bitmap Pimage { get => pimage; set => pimage = value; }
        public string Padress { get => padress; set => padress = value; }
        public float Latitude { get => latitude; set => latitude = value; }
        public float Longitude { get => longitude; set => longitude = value; }
    }
}
