using System;
using System.Security.Cryptography.X509Certificates;

namespace Triangle
{
    public class Triangle
    {
        int x;
        int y;
        int z;
        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public int Z
        {
            set { z = value; }
            get { return z; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("X : " + X);
            Console.WriteLine("Y : " + Y);
            Console.WriteLine("Z : " + Z);
        }
        public void TestTriangle()

        {
            if (X == Y)
            {
                if (Y == Z)
                {
                    if(Z==X)
                    {
                        Console.WriteLine("3 equal sides");
                    }
                    else
                    {
                        Console.WriteLine("2 equal sides");
                    }

                   
                }
                else
                {
                    Console.WriteLine("2 equal sides");
                }
            }
            else
            {
                Console.WriteLine("2 equal sides");
            }



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Triangle T = new Triangle();
            T.X = 5;
            T.Y = 5;
            T.Z = 6;
            T.ShowInfo();
            T.TestTriangle();



        
        }
    }
}
