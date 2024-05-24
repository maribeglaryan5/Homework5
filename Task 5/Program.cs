namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal one = 5.5m;
            long two = (long)one;
            Console.WriteLine(one);
            long longvalue = long.MaxValue;
            float floatvalue = (float)longvalue;
            Console.WriteLine(longvalue);
            float name = float.MaxValue;
            double surname = (double)name;
            Console.WriteLine(name);
            double three = double.MaxValue;
            short four = (short)three;
            Console.WriteLine(three);
            short shortvalue = short.MaxValue;
            int five = (int)shortvalue;
            int intvalue = int.MaxValue;
            byte six = (byte)intvalue;
            Console.WriteLine(intvalue);
            string text = "50000";
            double ten = double.Parse(text);
            Console.WriteLine(text);
        }
    }
}
