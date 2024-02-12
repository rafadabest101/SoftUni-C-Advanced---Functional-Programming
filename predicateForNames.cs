namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split().ToArray();

            Predicate<string> checkLength = str => str.Length <= n;
            foreach(string name in names)
            {
                if (checkLength(name)) Console.WriteLine(name);
            }
        }
    }
}