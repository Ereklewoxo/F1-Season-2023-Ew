using System.Collections.Generic;
using System.IO;
using System.Text;

namespace F1_Season_2023_Ew
{
    public class Display
    {
        public static void Logo()
        {
            Console.Write("" +
                "                         ___   ____  ___  ____\n" +
                "                        |__ \\ / __ \\|__ \\|__  \\\n" +
                "                        / __// /_/ // __//__  /\n" +
                "                       /____/\\____//____/____/");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(0, Console.CursorTop - 3);
            Console.Write("" +
                  "     ______________  __\n" +
                  "   /  ____________//  /\n" +
                  "  /  /  _________//  /\n" +
                  " /__/__/         /__/\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DifficultyBar()
        {
            Menu difficulty = new();
            for (int i = 0; i < Menu.Difficulty; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("▐");
            }
            for (int i = 0; i < 5 - Menu.Difficulty; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("▐");
            }
        }
    }
    public class Data
    {
        public List<Tuple<string, string, string, string, string>> UserData()
        {
            var userData = new List<Tuple<string, string, string, string, string>>
            {
                new Tuple<string, string, string, string, string>("John", "Doe", "John Doe", "DOE", "Sealand")
            };
            string read;
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            StreamReader saveFileR = new($"{path}\\SaveFile.txt");
            read = saveFileR.ReadLine();
            if (read == null)
            {
                saveFileR.Close();
                StreamWriter saveFileW = new($"{path}\\SaveFile.txt");
                Console.WriteLine("\n     /What's your first name?");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"    /");
                Console.ForegroundColor = ConsoleColor.White;
                string? firstName = Console.ReadLine();
                if (firstName.Length == 1)
                {
                    firstName = firstName.ToUpper();
                }
                else if (firstName.Length == 0)
                {
                    firstName = "John";
                }
                else
                {
                    firstName = firstName.Remove(1).ToUpper() + firstName.Remove(0, 1).ToLower();
                }
                saveFileW.WriteLine(firstName);
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Console.WriteLine("     /And your last name?    ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"    /{firstName} ");
                Console.ForegroundColor = ConsoleColor.White;
                string? lastName = Console.ReadLine();
                if (lastName.Length == 1)
                {
                    lastName = lastName.ToUpper();
                }
                else if (lastName.Length == 0)
                {
                    lastName = "Doe";
                }
                else
                {
                    lastName = lastName.Remove(1).ToUpper() + lastName.Remove(0, 1).ToLower();
                }
                saveFileW.WriteLine(lastName);
                string fullName = firstName + " " + lastName;
                saveFileW.WriteLine(fullName);
                string shortName;
                if (lastName.Length == 3)
                {
                    shortName = lastName;
                }
                else if (firstName.Length + lastName.Length < 3)
                {
                    shortName = firstName + lastName;
                }
                else if (firstName.Length + lastName.Length == 3)
                {
                    shortName = firstName + lastName;
                }
                else if (firstName.Length > 1 && lastName.Length == 1)
                {
                    shortName = firstName.Remove(2) + lastName;
                }
                else if (firstName.Length > 1 && lastName.Length < 3)
                {
                    shortName = firstName.Remove(1) + lastName;
                }
                else
                {
                    shortName = lastName.Remove(3);
                }
                shortName = shortName.ToUpper();
                saveFileW.WriteLine(shortName);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"    /{firstName} {lastName}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   /Where are you from?");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"  /");
                Console.ForegroundColor = ConsoleColor.White;
                string? nationality = Console.ReadLine();
                if (nationality.Length == 1)
                {
                    nationality = nationality.ToUpper();
                }
                else if (nationality.Length == 0)
                {
                    nationality = "Sealand";
                }
                else
                {
                    nationality = nationality.Remove(1).ToUpper() + nationality.Remove(0, 1).ToLower();
                }
                saveFileW.WriteLine(nationality);
                Console.ForegroundColor = ConsoleColor.White;
                userData.Add(new Tuple<string, string, string, string, string>(firstName, lastName, fullName, shortName, nationality));
                saveFileW.Close();
                Console.SetCursorPosition(0, Console.CursorTop - 4);
            }
            return userData;
        }
        public static List<Tuple<string, string, string, int, string>> DriverData()
        {
            var driverData = new List<Tuple<string, string, string, int, string>>();
            driverData.Add(new Tuple<string, string, string, int, string>("Mercedes", "Lewis Hamilton", "HAM", 44, "United Kingdom"));
            driverData.Add(new Tuple<string, string, string, int, string>("Mercedes", "George Russell", "RUS", 63, "United Kingdom"));
            driverData.Add(new Tuple<string, string, string, int, string>("Red Bull", "Max Verstappen", "VER", 1, "Netherlands"));
            driverData.Add(new Tuple<string, string, string, int, string>("Red Bull", "Sergio Perez", "PER", 11, "Mexico"));
            driverData.Add(new Tuple<string, string, string, int, string>("Ferrari", "Charles Leclerc", "LEC", 16, "Monaco"));
            driverData.Add(new Tuple<string, string, string, int, string>("Ferrari", "Carlos Sainz", "SAI", 55, "Spain"));
            driverData.Add(new Tuple<string, string, string, int, string>("McLaren", "Lando Norris", "NOR", 4, "United Kingdom"));
            driverData.Add(new Tuple<string, string, string, int, string>("McLaren", "Oscar Piastri", "PIA", 81, "Australia"));
            driverData.Add(new Tuple<string, string, string, int, string>("Alpine", "Esteban Ocon", "OCO", 31, "France"));
            driverData.Add(new Tuple<string, string, string, int, string>("Alpine", "Pierre Gasly", "GAS", 10, "France"));
            driverData.Add(new Tuple<string, string, string, int, string>("AlphaTauri", "Yuki Tsunoda", "TSU", 22, "Japan"));
            driverData.Add(new Tuple<string, string, string, int, string>("AlphaTauri", "Nyck de Vries", "DEV", 45, "Netherlands"));
            driverData.Add(new Tuple<string, string, string, int, string>("Aston Martin", "Fernando Alonso", "ALO", 14, "Spain"));
            driverData.Add(new Tuple<string, string, string, int, string>("Aston Martin", "Lance Stroll", "STR", 18, "Canada"));
            driverData.Add(new Tuple<string, string, string, int, string>("Williams", "Alexander Albon", "ALB", 23, "Thailand"));
            driverData.Add(new Tuple<string, string, string, int, string>("Williams", "Logan Sargeant", "SAR", 6, "United States"));
            driverData.Add(new Tuple<string, string, string, int, string>("Alfa Romeo", "Valtteri Bottas", "BOT", 77, "Finland"));
            driverData.Add(new Tuple<string, string, string, int, string>("Alfa Romeo", "Zhou Guanyu", "ZHO", 24, "China"));
            driverData.Add(new Tuple<string, string, string, int, string>("Haas", "Kevin Magnussen", "MAG", 20, "Denmark"));
            driverData.Add(new Tuple<string, string, string, int, string>("Haas", "Nico Hulkenberg", "HUL", 24, "Germany"));
            return driverData;
        }
    }
    public class Menu
    {
        private static readonly int AnimSpeed = 23;
        public static int Difficulty = 3;
        public static void MenuAnim1()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 7; i++)
            {
                Task.Delay(AnimSpeed).Wait();
                Console.Write("_");
            }
        }
        public static void MenuAnim2()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 7; i++)
            {
                Task.Delay(AnimSpeed).Wait();
                if (i == 3)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("      /Quick Race    ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                    Console.Write("_");
                if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\r      /Quick Race    ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("___");
                }
            }
        }
        public static void MenuAnim3()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 11; i++)
            {
                Task.Delay(AnimSpeed).Wait();
                if (i == 5)
                {
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("     /Career Mode  ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("/");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
                else if (i == 7)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("      /Quick Race   ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("_");
                }
                else
                    Console.Write("_");
            }
        }
        public static void MainMenu()
        {
            Data data = new();
            ConsoleKeyInfo key;
            var selMenu = 0;
            var selMenuQ = 0;
            var selMenuC = 0;
            var selMenuS = 0;
            bool firstTime = true;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\r      /Quick Race        ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     /Career Mode                                             \n    /Settings            \n   /Exit Game                                 ");
            key = Console.ReadKey(true);
            do
            {
                Console.SetCursorPosition(0, Console.CursorTop - 4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\r      /Quick Race                                       \n     /Career Mode                                        \n    /Settings                  \n   /Exit Game                 ");
                do
                {
                    while (selMenu == 0)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("      /Quick Race");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("     /Career Mode\n    /Settings\n   /Exit Game");
                        if (firstTime == false)
                            key = Console.ReadKey(true);
                        firstTime = false;
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenu = 1;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu == 1)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("      /Quick Race");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("     /Career Mode");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("    /Settings\n   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenu = 2;
                        else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenu = 0;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu == 2)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("      /Quick Race\n     /Career Mode");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("    /Settings");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenu = 1;
                        else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenu = 3;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenu == 3)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("      /Quick Race\n     /Career Mode\n    /Settings");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenu = 2;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                } while (key.Key != ConsoleKey.Enter);
                while (selMenu == 0)
                {
                    while (selMenuQ == 0)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("      /Quick Race");
                        MenuAnim1(); 
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("/Start Random Race");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("     /Career Mode      ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/Choose a Circuit");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("    /Settings\n   /Exit Game");
                        selMenuQ = 1;
                    }
                    while (selMenuQ == 1)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("      /Quick Race_______");
                        Console.WriteLine("/Start Random Race");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("     /Career Mode      ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/Choose a Circuit");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("    /Settings\n   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenuQ = 2;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenuQ == 2)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("      /Quick Race_______");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/Start Random Race");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("     /Career Mode      ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("/Choose a Circuit");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("    /Settings\n   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenuQ = 1;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        selMenuQ = 0;
                        break;
                    }
                }
                while (selMenu == 1)
                {
                    while (selMenuC == 0)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("      /Quick Race");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("     /Career Mode");
                        MenuAnim2();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("/New Game");
                        Console.Write("     /Career Mode___/  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/Load Game");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("    /Settings\n   /Exit Game");
                        selMenuC = 1;
                    }
                    while (selMenuC == 1)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("      /Quick Race    ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("___/New Game");
                        Console.Write("     /Career Mode___/  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/Load Game");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("    /Settings\n   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenuC = 2;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenuC == 2)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("      /Quick Race    ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("___");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/New Game");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("     /Career Mode___/  ");
                        Console.WriteLine("/Load Game");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("    /Settings\n   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenuC = 1;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        selMenuC = 0;
                        break;
                    }
                }
                while (selMenu == 2)
                {
                    while (selMenuS == 0)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("      /Quick Race\n     /Career Mode");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("    /Settings");
                        MenuAnim3();
                        Console.WriteLine("/Difficulty");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("     /Career Mode  ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("/");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("   /Exit Game");
                        selMenuS = 1;
                    }
                    while (selMenuS == 1)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("      /Quick Race   ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("____/Difficulty");
                        Display.DifficultyBar();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("     /Career Mode  ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("/");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   /Change User Data");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("    /Settings");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("   /Exit Game");
                        key = Console.ReadKey(true);
                        if ((key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A) && Difficulty != 1)
                            Difficulty--;
                        else if ((key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D) && Difficulty != 5)
                            Difficulty++;
                        else if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                            selMenuS = 2;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    while (selMenuS == 2)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 4);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("      /Quick Race   ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("____");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("/Difficulty               ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("     /Career Mode  ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("/");
                        Console.WriteLine("   /Change User Data");
                        Console.WriteLine("    /Settings");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("   /Exit Game");
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
                            selMenuS = 1;
                        else if (key.Key == ConsoleKey.Escape)
                            break;
                        else if (key.Key == ConsoleKey.Enter)
                            break;
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        selMenuS = 0;
                        break;
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Display.Logo();
            Data data = new Data();
            var userData = data.UserData();
            Menu.MainMenu();
        }
    }

}