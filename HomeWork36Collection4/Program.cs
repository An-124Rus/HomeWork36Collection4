internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> personnelsAccounts = new Dictionary<string, string>();

        Console.WriteLine("Добро пожаловать в кадровый учёт!\n");
        Console.WriteLine("Для продолжения нажмите любую клавишу");
        Console.ReadKey();
        Console.Clear();

        TakeUserChoice(personnelsAccounts);
    }

    static void CreateAccount(Dictionary<string, string> personnelsAccounts)
    {
        Console.Clear();
        Console.Write("Введите фамилию с большой буквы: ");
        string name = Console.ReadLine();

        Console.Write("Введите должность: ");
        string post = Console.ReadLine();

        personnelsAccounts.Add(name, post);

        Console.WriteLine("\nДосье внесено. Для продолжения нажмите любую клавишу");
        Console.ReadKey();
    }

    static void OutputAccount(Dictionary<string, string> personnelsAccounts)
    {
        Console.Clear();
        Console.Write("Введите фамилию с большой буквы: ");
        string name = Console.ReadLine();

        if (personnelsAccounts.ContainsKey(name))
        {
            Console.WriteLine($"{name} - {personnelsAccounts[name]}");
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nТакой фамилии нет. Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }

    static void OutputAllAccounts(Dictionary<string, string> personnelsAccounts)
    {
        Console.Clear();

        foreach (var accounts in personnelsAccounts)
        {
            Console.WriteLine($"{accounts.Key} - {accounts.Value}");
        }

        Console.WriteLine("\nДля продолжения нажмите любую клавишу");
        Console.ReadKey();
    }

    static void DeleteAccount(Dictionary<string, string> personnelsAccounts)
    {
        Console.Clear();
        Console.Write("Введите фамилию  с большой буквы: ");
        string name = Console.ReadLine();

        if (personnelsAccounts.ContainsKey(name))
        {
            personnelsAccounts.Remove(name);

            Console.WriteLine("\nДосье удалёно. Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nТакой фамилии нет. Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }

    static void TakeUserChoice(Dictionary<string, string> personnelsAccounts)
    {
        const string CreateAccount = "1";
        const string OutputAccount = "2";
        const string OutputAllAccounts = "3";
        const string DeleteAccount = "4";
        const string Exit = "5";

        bool isWorking = true;

        while (isWorking)
        {
            Console.WriteLine($"Для добавления досье нажмите  - {CreateAccount}");
            Console.WriteLine($"Для вывода досье нажмите      - {OutputAccount}");
            Console.WriteLine($"Для вывода всех досье нажмите - {OutputAllAccounts}");
            Console.WriteLine($"Для удаления досье нажмите    - {DeleteAccount}");
            Console.WriteLine($"Для выхода нажмите            - {Exit}\n");

            string userInput = Console.ReadLine();

            if (isWorking)
            {
                switch (userInput)
                {
                    case CreateAccount:
                        Program.CreateAccount(personnelsAccounts);
                        break;
                    case OutputAccount:
                        Program.OutputAccount(personnelsAccounts);
                        break;
                    case OutputAllAccounts:
                        Program.OutputAllAccounts(personnelsAccounts);
                        break;
                    case DeleteAccount:
                        Program.DeleteAccount(personnelsAccounts);
                        break;
                    case Exit:
                        isWorking = false;
                        break;
                }
            }

            Console.Clear();
        }
    }
}