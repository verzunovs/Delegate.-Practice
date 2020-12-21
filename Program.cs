namespace PracticeWithDelegates
{
    public class Program
    {
        private static ResultHandler result;
        private static ShowHandler show = Show;

        private static void Main(string[] args)
        {
            PowHandler pow = null;
            var c2 = new Class2();
            result = c2.Calc(pow, 10, 9);
            bool flag = result(10);
            show(flag);
        }

        private static void Show(bool flag)
        {
            System.Console.WriteLine($"{flag}");
        }
    }
}
