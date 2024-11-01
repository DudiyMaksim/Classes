using System.Net;

namespace Classes
{
    internal class Program
    {
          class Methods
        {
            public void MadeCube(string value)
            {
                if (int.Parse(value) > 1) {
                    for (int i = 0; i < int.Parse(value); i++)
                    {
                        Console.Write(value);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < int.Parse(value) - 2; i++)
                    {
                        Console.Write(value);
                        for (int j = 0; j < int.Parse(value) - 2; j++)
                        {
                            if (int.Parse(value)>9)
                            {
                                Console.Write("  ");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.Write(value);
                        Console.WriteLine();
                    }
                    for (int i = 0; i < int.Parse(value); i++)
                    {
                        Console.Write(value);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(value);
                }
            }

            public bool IsPalindrome(string value)
            {
                if (value.Length%2==0)
                {
                    for (int i = 0; i < value.Length / 2; i++)
                    {
                        if (value[i] != value[value.Length - i - 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    for (int i = 0; i < (value.Length-1) / 2; i++)
                    {
                        if (value[i] != value[value.Length - i - 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }

            public int[] ArrayFiltering(int[] main, int[] filter)
            {
                List<int> filteredValues = new List<int>();

                for (int i = 0; i < main.Length; i++)
                {
                    if (!filter.Contains(main[i]))
                    {
                        filteredValues.Add(main[i]);
                    }
                }

                return filteredValues.ToArray();
                // моїм способом через string += не вийшло char в int не парситься
            }
        }


        class WebSite
        {
            string name;
            string path;
            string description;
            string IpAdress;

            public WebSite(string name, string path, string description, string ipAdress)
            {
                this.name = name;
                this.path = path;
                this.description = description;
                IpAdress = ipAdress;
            }

            public void InputData()
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();

                Console.Write("Enter path: ");
                path = Console.ReadLine();

                Console.Write("Enter description: ");
                description = Console.ReadLine();

                Console.Write("Enter IP address: ");
                IpAdress = Console.ReadLine();
            }
            public void DisplayData()
            {
                Console.WriteLine("Site Name: " + name);
                Console.WriteLine("Site Path: " + path);
                Console.WriteLine("Description: " + description);
                Console.WriteLine("IP Address: " + IpAdress);
            }

            public string GetName() => name;
            public void SetName(string name) => this.name = name;

            public string GetPath() => path;
            public void SetPath(string path) => this.path = path;

            public string GetDescription() => description;
            public void SetDescription(string description) => this.description = description;

            public string GetIpAddress() => IpAdress;
            public void SetIpAddress(string IpAdress) => this.IpAdress = IpAdress;
        }

        static void Main(string[] args)
        {
            Methods methods = new Methods();

            methods.MadeCube(Console.ReadLine());
            Console.WriteLine(methods.IsPalindrome(Console.ReadLine()));
            int[] main = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filter = { 6, 88, 7 };
            int[] result = methods.ArrayFiltering(main, filter);
            foreach (int i in result) { 
                Console.Write(i + " ");
            }
        }
    }
}
