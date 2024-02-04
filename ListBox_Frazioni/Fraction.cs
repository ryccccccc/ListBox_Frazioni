using System;

namespace Frazioni
{
    public class Fraction
    {
        public int N { get; }
        public int D { get; }

        public Fraction(int n, int d)
        {
            if(d < 0)
            {
                n = -n; 
                d = -d;
            }
            Semplifica(ref n, ref d);

            N = n;
            D = d;
        }

        private void Semplifica(ref int n, ref int d)
        {
            int mcd = CalcolaMcd(n, d);
            n = n / mcd;
            d = d / mcd;
        }

        private int CalcolaMcd(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        public Fraction Somma(Fraction other)
        {
            return new Fraction(this.N * other.D + this.D * other.N, this.D * other.D);
        }
        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.N * f2.D + f1.D * f2.N, f1.D * f2.D);
        }

        public Fraction Sottrai(Fraction other)
        {
            return new Fraction(this.N * other.D - this.D * other.N, this.D * other.D);
        }
        public static Fraction operator-(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.N * f2.D - f1.D * f2.N, f1.D * f2.D);
        }

        public Fraction Moltiplica(Fraction other)
        {
            return new Fraction(this.N * other.N, this.D * other.D);
        }
        public static Fraction operator*(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.N * f2.N, f1.D * f2.D);
        }

        public Fraction Dividi(Fraction other)
        {
            return new Fraction(this.N * other.D, this.D * other.N);
        }
        public static Fraction operator/(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.N * f2.D, f1.D * f2.N);
        }
        public static Fraction operator-(Fraction f)
        {
            return new Fraction(-f.N, f.D);
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.N == f2.N && f1.D == f2.D;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }


        public override string ToString()
        {
            return $"{N}/{D}";
        }


        public static Fraction Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        public static bool TryParse(string s, out Fraction v)
        {
            String[] parts = s.Split('/');
            if(parts.Length != 2)
            {
                v = null;
                return false;
            }

            int n;
            if (int.TryParse(parts[0], out n))
            {
                v = null;
                return false;
            }
            int d;
            if (int.TryParse(parts[0], out d))
            {
                v = null;
                return false;
            }
            v = new Fraction(n, d);
            return true;
        }
    }
}
