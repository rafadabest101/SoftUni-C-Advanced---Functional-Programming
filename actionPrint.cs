namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine(n);
            string[] strs = Console.ReadLine().Split().ToArray();
            foreach(string str in strs) print(str);
        }
    }
}