using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using MusicApp;


namespace MusicApp
{
    internal class Program
    {
        private static void WaitForKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            MusicLibrary playlist = new MusicLibrary();
            bool exit = false;

            // Tải danh sách nhạc từ file MusicList.txt
            string filePath = "C:\\Users\\Le Cong Bao\\source\\repos\\MusicManagement\\MusicManagement\\MusicList\\MusicList.txt";
            playlist.LoadMusicFromFile(filePath);

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("===         Music Playlist Manager      ===");
                Console.WriteLine("===========================================");
                Console.WriteLine("1. Add Music");
                Console.WriteLine("2. Remove Music");
                Console.WriteLine("3. Display Music");
                Console.WriteLine("4. Play Music");
                Console.WriteLine("5. Exit");
                Console.WriteLine("===========================================");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter music title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter artist name: ");
                        string artist = Console.ReadLine();
                        playlist.AddMusic(title, artist);
                        WaitForKey();
                        break;

                    case "2":
                        Console.Write("Enter the title of the music to remove: ");
                        string titleToRemove = Console.ReadLine();
                        playlist.RemoveMusic(titleToRemove);
                        WaitForKey();
                        break;

                    case "3":
                        playlist.DisplayMusic();
                        WaitForKey();
                        break;

                    case "4":
                        playlist.PlayMusic();
                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        WaitForKey();
                        break;
                }
            }
        }

    }
}







