using System;
using System.IO;


namespace search_service
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            Data d;
            do
            {
                Search s1 = new Search();
                //Each time the "newFileFound" event occurs,
                //the file name and path(fileData) will be displayed on the screen.
                s1.newFileFound += new fileHandler((fileData) => Console.WriteLine(fileData));
                
                Console.WriteLine("Please choose:\n" +
                                  "1. Enter File Name to search\n" +
                                  "2. Enter file name + Searcing Path\n" +
                                  "3. Exit");
                choice = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (choice)
                {
                    case '1':
                        Console.Write("Plese write a file name:");
                        s1.keyWord = Console.ReadLine();
                        if (s1.keyWord == "")
                        {
                            Console.WriteLine("File name is required.");
                            Console.WriteLine();
                            continue;
                        }
                        Console.WriteLine("Searching...");
                        s1.fileSearch(s1.keyWord);

                        //The 'Data' class and the 'post' method are dealing with transferring information to the database
                        d = new Data(s1);
                        d.Post();  
                        break;
                    case '2':
                        Console.Write("Plese write a file name:");
                        s1.keyWord = Console.ReadLine();
                        if (s1.keyWord == "")
                        {
                            Console.WriteLine("File name is required.");
                            Console.WriteLine();
                            continue;
                        }
                        Console.Write($"Plese enter a path: {s1.searchPath}");
                        s1.searchPath += Console.ReadLine();

                        //To avoid input problems in case the user entered a path ending with a slash (\)
                        while (s1.searchPath.EndsWith("\\"))
                        {
                            s1.searchPath = s1.searchPath.Remove(s1.searchPath.Length - 1);
                        }
                        Console.WriteLine("Searching...");
                        try
                        {
                            s1.fileSearch(s1.keyWord, s1.searchPath);
                            if (s1.results.Count == 0) //No results
                            {
                                Console.WriteLine($"No file containing the name '{s1.keyWord}' was found.");
                            }
                            d = new Data(s1);
                            d.Post();
                        }
                        catch (DirectoryNotFoundException e) // The path does not exist
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case '3':
                        continue;
                    default:
                        Console.Clear();
                        Console.WriteLine("Input must be '1', '2' or '3'\n");
                        continue;
                }
                Console.Write("\nPress 'ENTER' to start a new search, or 'e' to EXIT ");
                if (Console.ReadLine().ToLower() == "e") break;
                s1.searchPath = "C:\\Users"; //Resets the path for the next search
                Console.Clear();
            } while (choice != '3');
        }
    }
}
