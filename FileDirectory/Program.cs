namespace FileDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool check = false;
            bool subcheck = false;
            bool f = false;
            string pathFile;
            bool k;
            do
            {
                int choice;
                do
                {
                    Console.WriteLine("1.Folder yarat");
                    Console.WriteLine("2.File yarat");
                    Console.WriteLine("0.Exit");
                    Console.WriteLine("Secim edin: ");
                }
                while (!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 1:
                    l1:
                        Console.Write("Folder adi daxil edin: ");
                        string name = Console.ReadLine();
                        string path = "C:\\Users\\ca.r214.14\\Desktop\\" + name;
                        DirectoryInfo directoryInfo = new DirectoryInfo(path);
                        string answer;

                        f = false;
                        while (!directoryInfo.Exists)
                        {
                            f = true;
                            directoryInfo.Create();
                        }

                        if (f == false)
                        {
                            Console.WriteLine("Folder movcuddur!");
                        }

                        Console.Write("Yeni folder yaratmaq isteyirsiniz? (yes/no)");
                        answer = Console.ReadLine();

                        if (answer == "yes")
                        {
                            goto l1;
                        }
                        else if (answer == "no")
                        {
                            foreach (var item in directoryInfo.GetDirectories())
                            {
                                Console.Write($"{item.FullName} - {item.CreationTime}");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("File adi daxil edin: ");
                        name = Console.ReadLine();
                        pathFile = "C:\\Users\\ca.r214.14\\Desktop\\" + name;

                        FileInfo fileInfo = new FileInfo(pathFile);
                        k = true;
                        while (k == true)
                        {
                            File.Create(pathFile).Close();
                            k = false;
                        }

                        if (k == true)
                        {
                            Console.WriteLine("File movcuddur!");
                        }
                        Console.Write("Yazi yazmag isteyirsiniz? (yes/no)");
                        answer = Console.ReadLine();

                        if (answer == "yes")
                        {
                            string text = Console.ReadLine();
                            File.WriteAllText(pathFile, text);
                        }
                        Console.WriteLine("oxumaq istiyirsiniz?");
                        answer= Console.ReadLine();
                        if (answer == "yes")
                        {
                            foreach (var item in File.ReadAllLines(pathFile))
                            {
                                Console.WriteLine(item);
                            };

                        }
                        else
                        {
                            Console.WriteLine("okai");
                        }
                        break;
                    case 0:
                        check = true;
                        break;

                }

            }
            while (!check);


        }
    }
}