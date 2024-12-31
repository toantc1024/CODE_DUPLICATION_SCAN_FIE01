using System;
using System.IO;
using System.Linq;
using MusicTree;
using TagLib;

class Program
{
    static void Main(string[] args)
    {
        MusicBST musicList = new MusicBST();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a single music file by path");
            Console.WriteLine("2. Add multiple music files from a folder by path");
            Console.WriteLine("3. Remove a song by length");
            Console.WriteLine("4. Display all songs");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddMusicFile(musicList);
                    break;

                case "2":
                    AddMusicFromFolder(musicList);
                    break;

                case "3":
                    RemoveMusicFile(musicList);
                    break;

                case "4":
                    DisplayAllSongs(musicList);
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddMusicFile(MusicBST musicList)
    {
        Console.Write("Enter the full file path of the music file: ");
        string filePath = Console.ReadLine();

        if (System.IO.File.Exists(filePath))
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                int length = (int)file.Properties.Duration.TotalSeconds;
                string title = file.Tag.Title ?? Path.GetFileNameWithoutExtension(filePath);
                string artist = file.Tag.FirstPerformer ?? "Unknown Artist";

                musicList.Insert(length, title, artist);
                Console.WriteLine($"Added: {title} by {artist}, Length: {length} seconds.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading metadata from file: {ex.Message}");
            }
        }
        else
            Console.WriteLine("File does not exist.");
    }

    static void AddMusicFromFolder(MusicBST musicList)
    {
        Console.Write("Enter the full folder path: ");
        string folderPath = Console.ReadLine();

        if (Directory.Exists(folderPath))
        {
            var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                                 .Where(file => file.EndsWith(".mp3") || file.EndsWith(".wav") || file.EndsWith(".flac"));

            foreach (var file in files)
            {
                try
                {
                    var musicFile = TagLib.File.Create(file);
                    int length = (int)musicFile.Properties.Duration.TotalSeconds;
                    string title = musicFile.Tag.Title ?? Path.GetFileNameWithoutExtension(file);
                    string artist = musicFile.Tag.FirstPerformer ?? "Unknown Artist";

                    musicList.Insert(length, title, artist);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading metadata from file {file}: {ex.Message}");
                }
            }

            Console.WriteLine($"Scanned {files.Count()} music files and added them to the list.");
        }
        else
        {
            Console.WriteLine("Folder does not exist.");
        }
    }

    static void RemoveMusicFile(MusicBST musicList)
    {
        Console.Write("Enter the length of the song to remove: ");
        if (int.TryParse(Console.ReadLine(), out int length))
        {
            bool removed = musicList.Remove(length);
            if (removed)
                Console.WriteLine($"Song with length {length} seconds removed successfully.");
            else
                Console.WriteLine($"Song with length {length} seconds not found.");
        }
        else
        {
            Console.WriteLine("Invalid length input.");
        }
    }

    static void DisplayAllSongs(MusicBST musicList)
    {
        Console.WriteLine("\nAll Songs (sorted by length):");
        musicList.InOrder();
    }
}
