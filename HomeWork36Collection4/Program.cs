internal class Program
{
    private static void Main(string[] args)
    {
        const string CreateAccount = "1";
        const string OutputAccount = "2";
        const string OutputAllAccounts = "3";
        const string DeleteAccount = "4";
        const string Exit = "5";

        Dictionary<string, string> dossiers = new Dictionary<string, string>();

        Console.WriteLine("Добро пожаловать в кадровый учёт!\n");
        Console.WriteLine("Для продолжения нажмите любую клавишу");
        Console.ReadKey();
        Console.Clear();

        bool isWorking = true;

        while (isWorking)
        {
            Console.WriteLine($"Для добавления досье нажмите  - {CreateAccount}");
            Console.WriteLine($"Для вывода досье нажмите      - {OutputAccount}");
            Console.WriteLine($"Для вывода всех досье нажмите - {OutputAllAccounts}");
            Console.WriteLine($"Для удаления досье нажмите    - {DeleteAccount}");
            Console.WriteLine($"Для выхода нажмите            - {Exit}\n");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case CreateAccount:
                    Program.CreateAccount(dossiers);
                    break;
                case OutputAccount:
                    Program.OutputAccount(dossiers);
                    break;
                case OutputAllAccounts:
                    Program.OutputAllAccounts(dossiers);
                    break;
                case DeleteAccount:
                    Program.DeleteAccount(dossiers);
                    break;
                case Exit:
                    isWorking = false;
                    break;
            }

            Console.Clear();
        }
    }
    static void CreateAccount(Dictionary<string, string> dossiers)
    {
        Console.Clear();
        Console.Write("Введите фамилию с большой буквы: ");
        string name = Console.ReadLine();

        Console.Write("Введите должность: ");
        string post = Console.ReadLine();

        if (dossiers.ContainsKey(name))
        {
            Console.WriteLine("\nТакая фамилия уже есть. Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }
        else
        {
            dossiers.Add(name, post);
            Console.WriteLine("\nДосье внесено. Для продолжения нажмите любую клавишу");
        }
           
        Console.ReadKey();
    }

    static void OutputAccount(Dictionary<string, string> dossiers)
    {
        Console.Clear();
        Console.Write("Введите фамилию с большой буквы: ");
        string name = Console.ReadLine().ToLower();

        if (dossiers.ContainsKey(name.ToLower()))
        {
            Console.WriteLine($"{name} - {dossiers[name]}");
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nТакой фамилии нет. Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }

    static void OutputAllAccounts(Dictionary<string, string> dossiers)
    {
        Console.Clear();

        foreach (var account in dossiers)
        {
            Console.WriteLine($"{account.Key} - {account.Value}");
        }

        Console.WriteLine("\nДля продолжения нажмите любую клавишу");
        Console.ReadKey();
    }

    static void DeleteAccount(Dictionary<string, string> dossiers)
    {
        Console.Clear();
        Console.Write("Введите фамилию  с большой буквы: ");
        string name = Console.ReadLine().ToLower();

        if (dossiers.ContainsKey(name.ToLower()))
        {
            dossiers.Remove(name);

            Console.WriteLine("\nДосье удалёно. Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nТакой фамилии нет. Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}