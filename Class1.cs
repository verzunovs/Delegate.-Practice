namespace PracticeWithDelegates
{
    public class Class1
    {
        public delegate void ShowHandler(bool flag);

        public ShowHandler ShowH { get; set; }

        public static int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
