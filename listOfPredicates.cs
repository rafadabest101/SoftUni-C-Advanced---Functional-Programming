namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, bool> checker = (a, b) => a % b == 0;

            HashSet<int> divisibles = new HashSet<int>();
            for(int i = 1; i <= n; i++)
            {
                bool toAdd = true;
                foreach(int num in nums)
                {
                    if(!checker(i, num)) toAdd = false;
                }
                if(toAdd) divisibles.Add(i);
            }

            Console.WriteLine(string.Join(' ', divisibles));
        }
    }
}