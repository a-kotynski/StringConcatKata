namespace StringConcatKata;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Smash());
        //Smash();
        Console.WriteLine(Smash2());

        //static string Smash()
        //{
        //string[] fragmentedString = { "hello", "world", "this", "is", "great" };
        //string concatenatedString = string.Empty;
        //for (int i = 0; i < 5; i++)
        //{
        //    concatenatedString = String.Concat(fragmentedString[i]);
        //    Console.WriteLine(fragmentedString[i]);
        //}
        //Console.WriteLine(concatenatedString);
        //return concatenatedString;
        //}
        static string Smash2() // should work, but doesn't on kata page (readme)
        {
            string[] fragmentedString = { "hello", "world", "this", "is", "great" };
            string concatenatedString = string.Join(" ", fragmentedString);
            return concatenatedString;

        }
    }
}