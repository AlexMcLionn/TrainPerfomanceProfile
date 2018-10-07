using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPProfil
{
    public class Profil
    {
        private string name;
        private double startP;
        private double endP;

        private List<Curve> curves;
        private List<Grade> grades;
        private List<Station> stations;
       // private ArrayList signs;
       // private ArrayList signals;
        private List<CWRail> welded;

        public Profil()
        {
            this.curves = new List<Curve>();
            this.grades = new List<Grade>();
            this.stations = new List<Station>();
           // this.signs = new ArrayList();
           // this.signals = new ArrayList();
            this.welded = new List<CWRail>();
        }

        public Profil(string n, double start, double end)
        {
            name = n;
            startP = start;
            endP = end;

            this.curves = new List<Curve>();
            this.grades = new List<Grade>();
            this.stations = new List<Station>();
           // this.signs = new ArrayList();
           // this.signals = new ArrayList();
            this.welded = new List<CWRail>();

        }

        public void AddCurve(Curve c)
        {
            this.curves.Add(c);
        }

        public void AddGrade(Grade g)
        {
            this.grades.Add(g);
        }

        public void AddStation(Station s)
        {
            this.stations.Add(s);
        }

        public double ReciprocalRad (double p)
        {
            foreach (Curve b in this.curves)
                if (p < (b.getPe - b.getEase) && p > (b.getPs + b.getEase))
                    return 1 / b.getR;

                else if (p < b.getPe && p > b.getPs)
                    return 0.5 / b.getR;

            return 0;
        }


        public double GradeAt (double p)
        {
            foreach (Grade b in this.grades)
                if (p < b.getPe && p > b.getPs)
                    return b.getI;
            return 0;
        }

        public bool IsWeldedAt (double p)
        {
            foreach (CWRail b in this.welded)
                if (p < b.getPe && p > b.getPs)
                    return true;

            return false;
        }

        public double getLength ()
        {
            double l;
            l = Math.Abs(endP - startP);
            return l;
        }

    }
}
