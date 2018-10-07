using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPProfil
{
    public class Grade
    {
        private double I;  //плюс - подъём по ходу километров, число в промилле.
        private double ps;
        private double pe;

        //Constructor
        public Grade(double slope, double start, double end)
        {
            I = slope;
            ps = start;
            pe = end;
        }

        public double getI { get => I; }
        public double getPs { get => ps; }
        public double getPe { get => pe; }
    }
}
