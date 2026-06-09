using System;
using System.IO;
using System.Threading;


public static class Start
{
    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Clear();
        LoadMenu();
        ConsoleKeyInfo Select = Console.ReadKey();
        switch (Select.Key)
        {
            case (ConsoleKey.D1): Create();break;
            case (ConsoleKey.D2): Console.WriteLine("Coming Soon Pleas Wait For Version 1.5");Thread.Sleep(200);LoadMenu();break;
            case (ConsoleKey.D3): Open();break; 
        }
    }
    public static void LoadMenu()
    {
        Console.Clear();
        Console.WriteLine("Hello , Welcome To Code Beat Version 1.0!🎵");
        Console.WriteLine("1.Start Create");
        Console.WriteLine("2.Start Create With frequency");
        Console.WriteLine("3.Run File");
        Console.WriteLine("4.Exit");
    }
    public static void Create()
    {
        Console.Clear();
        Console.Write("Inter Your Notes : ");
        string? Melody = Console.ReadLine();
        Melody = Melody.ToUpper();
        foreach (char Note in Melody)
        {
            switch (Note)
            {
                case ('P'): Console.Beep(880, 500);break;
                case (' '): Thread.Sleep(2);break;
                case ('E'): Console.Beep(225, 500);break;
                case ('T'): Console.Beep(400, 800);break;
                case ('G'): Console.Beep(750, 100);break;
                case ('Y'):Console.Beep(125, 600);break;
                case ('Z'): Console.Beep(8500, 200);break;
                case ('A'): Console.Beep(500, 500);break;
                case ('W'): Console.Beep(100, 200);
                    Console.Beep(100, 200);
                    break;
                default:
                    Console.WriteLine("This Note is Not Regoniazed");
                    Console.ReadKey();
                    break;
            }
        }
        Console.WriteLine("Save As ? (if You Want Save Write The Yes if Dont Want Save Write No)");
        string SaveResult = Console.ReadLine();
        if (SaveResult == "Yes")
        {
            try
            {
                Console.Clear();
                Console.Write("Write Your File Name ");
                string NameFile = Console.ReadLine();
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                string fullPath = Path.Combine(desktopPath, NameFile + ".txt");
                File.WriteAllText(fullPath, Melody);
                Console.WriteLine("Saving was successful.");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Saving was Not successful");
            }

        }
        else if (SaveResult == "No")
        {
            Console.Clear();
            Console.WriteLine("Your Melody Not Saved");
        }
    }
    public static void Open()
    {
        Console.Clear();
        Console.Write("Inter A full Path Of your Saved File txt : ");
        string? FilePath = Console.ReadLine();
        string? OpenedMelody = File.ReadAllText(FilePath);
        Console.WriteLine(OpenedMelody);
        foreach (char Note in OpenedMelody.ToUpper())
        {
            switch (Note)
            {
                case ('P'): Console.Beep(880, 500);break;
                case (' '): Thread.Sleep(2);break;
                case ('E'): Console.Beep(225, 500);break;
                case ('T'): Console.Beep(400, 800);break;
                case ('G'): Console.Beep(750, 100);break;
                case ('Y'):Console.Beep(125, 600);break;
                case ('Z'): Console.Beep(8500, 200);break;
                case ('A'): Console.Beep(500, 500);break;
                case ('W'): Console.Beep(100, 200);
                    Console.Beep(100, 200);
                    break;
                default:
                    Console.WriteLine("This Note is Not Regoniazed");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
