using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLineTask
{
    public class Class1
    {
        public static string defineTypeOfTriangle(double a_Side, double b_Side, double c_Side)
        {
            try
            {
                double longestSide = 0.0;
                double secondSide = 0.0;
                double thirdSide = 0.0;
                //определение большей стороны
                longestSide = Math.Max(a_Side, Math.Max(b_Side, c_Side));

                if (longestSide == a_Side)
                {
                    secondSide = b_Side;
                    thirdSide = c_Side;
                }
                else if (longestSide == b_Side)
                {
                    secondSide = a_Side;
                    thirdSide = c_Side;
                }
                else if (longestSide == c_Side)
                {
                    secondSide = a_Side;
                    thirdSide = b_Side;
                }
                //определение типа треугольника
                if (longestSide < (secondSide + thirdSide))
                {
                    if (Math.Pow(longestSide, 2) == (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)))
                    {
                        return "треугольник прямоугольный";
                    }
                    else if (Math.Pow(longestSide, 2) < (Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)))
                    {
                        return "треугольник остроугольный";
                    }
                    else
                    {
                        return "треугольник тупоугольный";
                    }
                }
                else
                {
                    return "ошибка";
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
