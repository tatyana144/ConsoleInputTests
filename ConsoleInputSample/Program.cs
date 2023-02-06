namespace ConsoleInputSample
{
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse);

            Console.WriteLine("The sum is:");
            Console.WriteLine(nums.Sum());
            
        }
    }
}