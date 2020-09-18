using System;

namespace triangleslides
{
    public class Triangle 
    {
        private readonly int a;
        private readonly int b;
        private readonly int c;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            Init();
        }

        public int A
        {
            get { return this.a; }
        }
        public int B
        {
            get
            {
                return this.b;
            }
        }
        public int C
        {
            get
            {
                return this.c;
            }
        }
       

       
        private bool Init()
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длины сторон треугольника должны быть больше нуля!!!");

            if (a > b + c || b > a + c || c > a + b)
                throw new ArgumentException("Не корректно указаны строны треугольника. Ни одна из  сторон треугольника не должна превосходить сумму других строн!!!");
            if((a * a + b * b <= c * c) || (a * a + c * c <= b * b) || (c * c + b * b <= a * a))
            {
                if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                {
                    Console.WriteLine("прямоугольный");
                }
                else
                {
                    Console.WriteLine("остроугольный");

                }

            }
            else
            {
                Console.WriteLine(" тупоугольный");

            }
            return true;

           
        }
     
    }
}

    
