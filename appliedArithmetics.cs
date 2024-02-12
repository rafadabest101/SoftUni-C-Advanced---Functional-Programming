namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> add = n => n + 1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> subtract = n => n - 1;
            Action<int[]> print = n => Console.WriteLine(String.Join(' ', n));

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while(command != "end")
            {
                switch(command)
                {
                    case "add":
                        for(int i = 0; i < nums.Length; i++) nums[i] = add(nums[i]);
                        break;
                    case "multiply":
                        for(int i = 0; i < nums.Length; i++) nums[i] = multiply(nums[i]);
                        break;
                    case "subtract":
                        for(int i = 0; i < nums.Length; i++) nums[i] = subtract(nums[i]);
                        break;
                    case "print":
                        print(nums);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}