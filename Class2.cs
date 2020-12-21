namespace PracticeWithDelegates
{
    public delegate int PowHandler(int x, int y);

    public delegate bool ResultHandler(int x);

    public class Class2
    {
        private static int resultOfPow;

        public static bool Result(int x)
        {
            if (resultOfPow % x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ResultHandler Calc(PowHandler pow, int x, int y)
        {
            ResultHandler result = Result;
            pow = Class1.Pow;
            if (pow != null)
            {
                resultOfPow = pow.Invoke(x, y);
            }

            return result;
        }
    }
}
