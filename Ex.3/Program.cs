namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> names = new List<string>(input.Split(','));

            for (int i = names.Count - 1; i >= 0; i--)
            {
                string[] name = names[i].Trim().Split(' ');
                Console.WriteLine($"{name[1]} {name[0]}");
            }
        }
    }
}
