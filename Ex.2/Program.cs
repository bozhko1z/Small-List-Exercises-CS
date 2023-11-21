namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            foreach (int num in nums)
            {
                string numStr = num.ToString();
                char[] charArray = numStr.ToCharArray();
                Array.Reverse(charArray);
                string reversedStr = new string(charArray);
                int reversedNum = int.Parse(reversedStr);
                sum += reversedNum;
            }

            Console.WriteLine(sum);
        }
    }
}
