using System;

namespace TestLibrary
{
    public static class Mathematics
    {
        public static T Add<T>(T ing1, T ing2)
        {
            dynamic a = ing1;
            dynamic b = ing2;

            try
            {
                return a + b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
        }

        public static T Subtract<T>(T minutend, T subtrahend)
        {
            dynamic a = minutend;
            dynamic b = subtrahend;
            try
            {
                return a - b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
        }

        public static T Multiply<T>(T fac1, T fac2)
        {
            dynamic a = fac1;
            dynamic b = fac2;
            try
            {

                return a * b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
        }

        public static T Divide<T>(T dividend, T devider)
        {
            dynamic a = dividend;
            dynamic b = devider;
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
        }
    }
}
