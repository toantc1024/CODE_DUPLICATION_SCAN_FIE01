using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace MusicApp
{
    internal class MusicLibrary
    {
        private Music tail;

        
        public void AddMusic(string title, string artist)
        {
            Music newMusic = new Music { Title = title, Artist = artist };

            if (tail == null)
            {
                tail = newMusic;
                tail.Next = tail; 
            }
            else
            {
                newMusic.Next = tail.Next; 
                tail.Next = newMusic; 
                tail = newMusic;
            }

            Console.WriteLine($"Added: {title} by {artist}");
        }


        
        public void RemoveMusic(string title)
        {
            if (tail == null)
            {
                Console.WriteLine("The playlist is empty!");
                return;
            }

            Music current = tail.Next;
            Music prev = tail;

            do
            {
                if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (current == tail && current.Next == tail)
                    {
                        tail = null;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == tail) tail = prev;
                    }

                    Console.WriteLine($"Removed: {title}");
                    return;
                }

                prev = current;
                current = current.Next;
            } while (current != tail.Next);

            Console.WriteLine($"Music '{title}' not found in the playlist.");
        }

        
        public void DisplayMusic()
        {
            if (tail == null)
            {
                Console.WriteLine("The playlist is empty!");
                return;
            }

            Music current = tail.Next;
            Console.WriteLine("+----------------------------+--------------------------+");
            Console.WriteLine("| Title                      | Artist                   |");
            Console.WriteLine("+----------------------------+--------------------------+");

            do
            {
                Console.WriteLine($"| {current.Title,-26} | {current.Artist,-24} |");
                current = current.Next;
            } while (current != tail.Next);

            Console.WriteLine("+----------------------------+--------------------------+");
        }


        
        public void PlayMusic()
        {
            if (tail == null)
            {
                Console.WriteLine("The playlist is empty!");
                return;
            }

            Music current = tail.Next;

            Console.WriteLine("Playing music. Select an option:");

            Stack<Music> history = new Stack<Music>();

            while (true)
            {
                Console.WriteLine($"\nNow playing: {current.Title} by {current.Artist}");
                Console.WriteLine("1. Next music");
                Console.WriteLine("2. Previous music");
                Console.WriteLine("3. Quit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine()?.Trim();

                switch (input)
                {
                    case "1":
                        history.Push(current);
                        current = current.Next;
                        break;

                    case "2":
                        if (history.Count > 0)
                        {
                            current = history.Pop();
                        }
                        else
                        {
                            current = tail;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Stopped playing music.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        break;
                }

                System.Threading.Thread.Sleep(1000);
            }
        }


        
        public void LoadMusicFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                Console.WriteLine("The file is empty!");
                return;
            }

            foreach (var line in lines)
            {
                Console.WriteLine($"Reading line: {line}"); 

                var parts = line.Split(":");

                
                if (parts.Length >= 4)
                {
                    string title = parts[2].Trim();   
                    string artist = parts[3].Trim();  

                    AddMusic(title, artist);
                }
                else
                {
                    Console.WriteLine($"Invalid format: {line}");
                }
            }
        }
    }
}




