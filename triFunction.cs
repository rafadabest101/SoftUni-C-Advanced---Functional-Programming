namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> func =
                (str, i) => i < str.Length;
            Func<Func<string, int, bool>, string, int, int, int> add = 
                (f, str, index, num) => f(str, index) ? num : 0;

            foreach(string name in names)
            {
                int sum = 0;
                foreach(char ch in name)
                {
                    sum += add(func, name, name.IndexOf(ch), ch);
                }
                if(sum >= n)
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
    }
}