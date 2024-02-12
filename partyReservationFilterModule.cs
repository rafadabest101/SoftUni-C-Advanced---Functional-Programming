namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> namesToRemove = new List<string>();

            string command = Console.ReadLine();
            while(command != "Print")
            {
                Func<string, string, bool> startsWith =
                    (str, str1) => str.Substring(0, str1.Length) == str1;
                Func<string, string, bool> endsWith =
                    (str, str1) => str.Substring(str.Length - str1.Length, str1.Length) == str1;
                Func<string, int, bool> length =
                    (str, i) => str.Length == i;
                Func<string, string, bool> contains =
                    (str, str1) => str.Contains(str1);


                string[] commandParts = command.Split(';');
                string commandType = commandParts[0];
                string criteria = commandParts[1];
                string str = commandParts[2];

                switch(criteria)
                {
                    case "Starts with":
                        foreach(string name in names)
                        {
                            if(startsWith(name, str)) namesToRemove = Filter(commandType, namesToRemove, name);
                        }
                        break;
                    case "Ends with":
                        foreach(string name in names)
                        {
                            if(endsWith(name, str)) namesToRemove = Filter(commandType, namesToRemove, name);
                        }
                        break;
                    case "Length":
                        foreach(string name in names)
                        {
                            if(startsWith(name, str)) namesToRemove = Filter(commandType, namesToRemove, name);
                        }
                        break;
                    case "Contains":
                        foreach(string name in names)
                        {
                            if(contains(name, str)) namesToRemove = Filter(commandType, namesToRemove, name);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            foreach(string name in namesToRemove) names.Remove(name);
            Console.WriteLine(string.Join(' ', names));
        }

        public static List<string> Filter(string commandType, List<string> namesToRemove, string name)
        {
            if(commandType == "Add filter") namesToRemove.Add(name);
            else if(commandType == "Remove filter") namesToRemove.Remove(name);
            return namesToRemove;
        }
    }
}