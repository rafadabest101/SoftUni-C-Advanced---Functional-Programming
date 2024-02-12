namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> reverse = arr => arr.Reverse();

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            reverse(nums);

            int n = int.Parse(Console.ReadLine());

            Predicate<int> check = num => num % n != 0;

            List<int> filteredNums = new List<int>();
            foreach(int num in nums)
            {
                if(check(num)) filteredNums.Add(num);
            }
            Console.WriteLine(String.Join(' ', filteredNums));
        }
    }
}