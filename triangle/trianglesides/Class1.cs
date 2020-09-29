using System;

namespace triangleslides

{



    public enum TriangleType
    {
        RightTriangle = 1,  // Прямоугольный
        OxygonTriangle = 2, //Остроугольный
        ObtuseTriangle = 3, //Тупоугольный
        Error = 4
    }

    public class Triangle
    {
        public static TriangleType GettypofTriangle(double a, double b, double c)

        {
          

            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.Error;


            if (a > b + c || b > a + c || c > a + b)
                return TriangleType.Error;

            if ((a * a + b * b <= c * c) || (a * a + c * c <= b * b) || (c * c + b * b <= a * a))
            {
                if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                {


                    return TriangleType.RightTriangle;
                }
                else
                {
                    return TriangleType.OxygonTriangle;

                }

            }
            else
            {
                return TriangleType.ObtuseTriangle;

            }


        }



    }
}

    
