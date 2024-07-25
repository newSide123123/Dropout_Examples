
namespace Sum_of_Digits
{
    internal class Program
    {
        public static int getNumberFromString(string s)
        {
            return Convert.ToInt32(new string(s.Where(char.IsDigit).ToArray()));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(getNumberFromString("hell5o wor6ld"));
        }
    }
}