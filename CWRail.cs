using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPProfil
{
    public class CWRail
    {
        private double ps;
        private double pe;

        //Constructor
        public CWRail(double start, double end)
        {
            ps = start;
            pe = end;
        }

        public double getPs { get => ps;}
        public double getPe { get => pe;}
    }
}
