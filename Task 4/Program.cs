namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryConvertedValue;
            string a = "23";
            string b = "I'm linguist and pedagogue";
            bool canParse = int.TryParse(b, out tryConvertedValue);
            Console.WriteLine(a);
            Console.WriteLine($"Can parse: {canParse}");
        }
    }
}
