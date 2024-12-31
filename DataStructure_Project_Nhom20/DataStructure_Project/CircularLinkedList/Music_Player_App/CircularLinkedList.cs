using System;
using System.Collections.Generic;

public class Song
{
    public string Title { get; set; }
    public string FilePath { get; set; }
    public Song Next { get; set; } // Con trỏ đến bài hát tiếp theo
    public override string ToString()
    {
        return Title;
    }
    public Song(string title, string filePath)
    {
        Title = title;
        FilePath = filePath;
        Next = null;
    }
}

public class CircularLinkedList
{
    private Song last; // Trỏ đến bài hát cuối cùng trong danh sách

    // Thêm bài hát mới vào danh sách
    public string AddSong(string title, string filePath)
    {
        Song newSong = new Song(title, filePath);

        if (last == null) // Nếu danh sách rỗng
        {
            last = newSong;
            last.Next = last; // Liên kết bài hát duy nhất
        }
        else
        {
            newSong.Next = last.Next; // Liên kết bài hát mới với bài hát đầu tiên
            last.Next = newSong; // Liên kết bài hát cuối với bài hát mới
            last = newSong; // Cập nhật bài hát cuối
        }
        return "Song added successfully.";
    }

    // Xóa bài hát khỏi danh sách
    public string DeleteSong(string title)
    {
        if (last == null) return "Playlist is empty.";

        Song current = last.Next; // Bắt đầu từ bài hát đầu tiên
        Song previous = last;

        do
        {
            if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (current == last && current.Next == last) // Nếu chỉ có một bài hát
                {
                    last = null;
                }
                else if (current == last) // Nếu là bài hát cuối
                {
                    previous.Next = current.Next;
                    last = previous;
                }
                else // Bài hát ở giữa hoặc đầu
                {
                    previous.Next = current.Next;
                }
                return "Song deleted successfully.";
            }

            previous = current;
            current = current.Next;
        } while (current != last.Next); // Lặp lại đến khi quay về bài đầu tiên

        return "Song not found.";
    }

    // Lấy danh sách tất cả bài hát dưới dạng mảng
    public string[] GetPlaylist()
    {
        if (last == null) return Array.Empty<string>();

        List<string> songs = new List<string>();
        Song current = last.Next;

        do
        {
            songs.Add($"{current.Title} | {current.FilePath}");
            current = current.Next;
        } while (current != last.Next);

        return songs.ToArray();
    }

    // Lấy đường dẫn tệp của bài hát theo tiêu đề
    public string GetFilePath(string title)
    {
        if (last == null) return null;

        Song current = last.Next;

        do
        {
            if (current.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return current.FilePath;
            }
            current = current.Next;
        } while (current != last.Next);

        return null; // Không tìm thấy bài hát
    }

    // Tìm kiếm bài hát theo tiêu chí
    public string[] SearchByCriteria(string searchTerm)
    {
        if (last == null) return Array.Empty<string>();

        List<string> matchingSongs = new List<string>();
        Song current = last.Next;

        do
        {
            if (current.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                current.FilePath.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
            {
                matchingSongs.Add($"{current.Title} | {current.FilePath}");
            }
            current = current.Next;
        } while (current != last.Next);

        return matchingSongs.ToArray();
    }
}
