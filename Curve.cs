using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPProfil
{
    public class Curve
    {
        private double R;
        private double ps;
        private double pe;
        private double easement;

        //Constructor
        public Curve(double radius, double start, double end, double easeLength)
        {
            R = radius;
            ps = start;
            pe = end;
            easement = easeLength;
        }

        public double getR { get => R;}
        public double getPs { get => ps;}
        public double getPe { get => pe;}
        public double getEase { get => easement;}
    }
}
