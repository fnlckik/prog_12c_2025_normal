using System;

namespace _3_Tergeometria
{
    internal abstract class Shape
    {
        // field: adattag
        public double r;
        public double m;

        public Shape(double r, double m = 0)
        {
            this.r = r;
            this.m = m;
        }

        // property: tulajdonság
        public abstract double Area { get; }
        public abstract double Volume { get; }
    }

    internal class Sphere : Shape
    {
        public Sphere(double r) : base(r)
        {
        }

        public override double Area
        {
            get
            {
                return 4 * r * r * Math.PI;
            }
        }

        public override double Volume
        {
            get
            {
                return 4 * Math.Pow(r, 3) * Math.PI / 3;
            }
        }

        public override string ToString()
        {
            return $"Gömb: R = {r}";
        }
    }

    internal class Cylinder : Shape
    {
        public Cylinder(double r, double m) : base(r, m)
        {
        }

        public override double Area => 2 * r * r * Math.PI + 2 * r * Math.PI * m;

        public override double Volume => r * r * Math.PI * m;

        public override string ToString()
        {
            return $"Henger: R = {r}, M = {m}";
        }
    }

    internal class Cone : Shape
    {
        public Cone(double r, double m) : base(r, m)
        {
        }

        public override double Area
        {
            get
            {
                double a = Math.Sqrt(m * m + r * r);
                return r * r * Math.PI + a * r * Math.PI;
            }
        }

        public override double Volume => r * r * Math.PI * m / 3;

        public override string ToString()
        {
            return $"Kúp: R = {r}, M = {m}";
        }
    }
}
