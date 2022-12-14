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

        Console.WriteLine("Досье внесено. Для продолжения нажмите любую клавишу");
        Console.ReadKey();
    }

    static void OutputAccount(Dictionary<string, string> personnelsAccounts)
    {
        Console.Clear();
        Console.Write("Введите фамилию с большой буквы: ");
        string name = Console.ReadLine().ToLower();

        if (personnelsAccounts.ContainsKey(name.ToLower()))
        {
            Console.WriteLine($"{name} - {personnelsAccounts[name]}");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Такой фамилии нет");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

    static void DeleteAccount(Dictionary<string, string> personnelsAccounts)
    {
        Console.Clear();
        Console.Write("Введите фамилию  с большой буквы: ");
        string name = Console.ReadLine().ToLower();

        personnelsAccounts.Remove(name.ToLower());

        Console.WriteLine("Досье удалёно. Для продолжения нажмите любую клавишу");
        Console.ReadKey();
    }

    static void TakeUserChoice(Dictionary<string, string> personnelsAccounts)
    {
        const string createAccount = "1";
        const string outputAccount = "2";
        const string deleteAccount = "3";
        const string exit = "4";

        bool isWorking = true;

        while (isWorking)
        {
            Console.WriteLine($"Для добавления досье нажмите - {createAccount}");
            Console.WriteLine($"Для вывода досье нажмите     - {outputAccount}");
            Console.WriteLine($"Для удаления досье нажмите   - {deleteAccount}");
            Console.WriteLine($"Для выхода нажмите           - {exit}\n");

            string userInput = Console.ReadLine();

            if (userInput != exit)
            {
                switch (userInput)
                {
                    case createAccount:
                        CreateAccount(personnelsAccounts);
                        break;
                    case outputAccount:
                        OutputAccount(personnelsAccounts);
                        break;
                    case deleteAccount:
                        DeleteAccount(personnelsAccounts);
                        break;
                }
            }
            else
            {
                isWorking = false;
            }

            Console.Clear();
        }
    }
}