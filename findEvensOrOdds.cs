namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rangeNums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string evenOrOdd = Console.ReadLine();
            int min = rangeNums[0];
            int max = rangeNums[1];

            List<int> nums = new List<int>();
            for(int i = min; i <= max; i++) nums.Add(i);

            Predicate<int> check = n => true;
            if(evenOrOdd == "even") check = n => n % 2 == 0;
            else if(evenOrOdd == "odd") check = n => n % 2 != 0;

            var evensOrOdds = nums.Where(new Func<int, bool>(check));
            Console.WriteLine(string.Join(' ', evensOrOdds));
        }
    }
}