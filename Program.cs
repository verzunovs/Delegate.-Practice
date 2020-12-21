namespace PracticeWithDelegates
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var c1 = new Class1();
            var c2 = new Class2();

            c1.ShowH = Show;
            c1.ShowH(c2.Calc(c2.Pow, 10, 8).Invoke(5));
        }

        private static void Show(bool flag)
        {
            System.Console.WriteLine($"{flag}");
        }
    }
}
