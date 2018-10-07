using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPProfil
{
    public enum SgType {tri=3, dojdo=4, trejdo=5}

    public class Signal
    {
        private double p;
        private string name;
        private bool stripe;

        private Aspect asp1;
        private Aspect asp2;
        private Aspect asp3;
        private Aspect asp4;
        private Aspect asp5;

        public double P { get => p; set => p = value; }

        public string getName()
        {
            return name;
        }
    }
}
