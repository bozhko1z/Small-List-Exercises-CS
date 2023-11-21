namespace Ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();

            names.Reverse();
            Console.WriteLine(String.Join("; ", names));
        }
    }
}
