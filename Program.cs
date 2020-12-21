namespace PracticeWithDelegates
{
    public class Program
    {
        private static ResultHandler result = Class2.Result;
        private static ShowHandler show = Show;

        private static void Main(string[] args)
        {
            bool flag = result(10);
            show(flag);
        }

        private static void Show(bool flag)
        {
            System.Console.WriteLine($"{flag}");
        }
    }
}
