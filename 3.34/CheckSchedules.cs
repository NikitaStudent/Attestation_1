using System;
namespace Application
{
    public struct CheckSchedules
    {
        // проверяет, находится ли точка (x, y)
        // выше линии y = a * (x - x0) + y0
        public static bool IsPointAboveLine(double x, double y, double x0, double y0, double a)
        {
            return y > a * (x - x0) + y0;
        }

        // проверяет, находится ли точка (x, y)
        // слева  от пораболы x = a * (y - y0) ^ 2 + x0
        public static bool IsPointLeftOfParabolaX(double x, double y, double x0, double y0, double a)
        {
            return x < a * Math.Pow(y - y0, 2) + x0;
        }
        // проверяет, находится ли точка (x, y)
        //  выше пораболы y = a * (x - x0) ^ 2 + y0
        public static bool IsPointAboveParabolaY(double x, double y, double x0, double y0, double a)
        {
            return y > a * Math.Pow(x - x0, 2) + y0;
        }

    }
}
