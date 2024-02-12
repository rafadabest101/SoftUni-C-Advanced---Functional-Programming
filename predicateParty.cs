namespace SU_funcProgExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, string, bool> startsWith = 
                (str, str1) => str.Substring(0, str1.Length) == str1;
            Func<string, string, bool> endsWith =
                (str, str1) => str.Substring(str.Length - str1.Length, str1.Length) == str1;
            Func<string, int, bool> hasLength =
                (str, i) => str.Length == i;

            List<string> namesToRemove = new List<string>();
            List<string> namesToDuplicate = new List<string>();

            string command = Console.ReadLine();
            while(command != "Party!")
            {
                string[] commandParts = command.Split();
                string commandType = commandParts[0];
                string criteria = commandParts[1];
                string criteriaStr = commandParts[2];

                switch(criteria)
                {
                    case "StartsWith":
                        foreach(string name in names)
                        {
                            if(startsWith(name, criteriaStr))
                            {
                                if(commandType == "Remove") namesToRemove.Add(name);
                                else namesToDuplicate.Add(name);
                            }
                        }
                        break;
                    case "EndsWith":
                        foreach(string name in names)
                        {
                            if(endsWith(name, criteriaStr))
                            {
                                if(commandType == "Remove") namesToRemove.Add(name);
                                else namesToDuplicate.Add(name);
                            }
                        }
                        break;
                    case "Length":
                        foreach(string name in names)
                        {
                            if(hasLength(name, int.Parse(criteriaStr)))
                            {
                                if(commandType == "Remove") namesToRemove.Add(name);
                                else namesToDuplicate.Add(name);
                            }
                        }
                        break;
                }

                if(commandType == "Remove")
                {
                    foreach(string name in namesToRemove) names.Remove(name);
                }
                else if(commandType == "Double")
                {
                    foreach(string name in namesToDuplicate) names.Insert(names.IndexOf(name), name);
                    namesToDuplicate.Clear();
                }
                command = Console.ReadLine();
            }

            if(names.Count == 0) Console.WriteLine("Nobody is going to the party!");
            else Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
        }
    }
}