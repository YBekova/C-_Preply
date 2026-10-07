namespace C__Preply;

public class Playlist
{
    private List<string> songsList;
    
    public int SongCount
    {
        get
        {
            return songsList.Count;
        }
    }

    public Playlist()
    {
        songsList = new List<string>();
    }

    public void AddSong()
    {
        Console.Write("Enter the song for the playlist: ");
        string input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input)) Console.WriteLine("Song name can't be empty!");
        else if (songsList.Contains(input)) Console.WriteLine("This song already exists!");
        else songsList.Add(input);
        
    }

    public void DeleteSongByName()
    {
        Console.WriteLine("Enter the song you want to delete from playlist: ");
        string input = Console.ReadLine();
        songsList.Remove(input);
    }

    public void DeleteSongByIndex()
    {
        Console.WriteLine("Enter the number of the song to delete: ");
       
        int input = Convert.ToInt32(Console.ReadLine());
        int index = input - 1;
        
        if (index >= 0 && index < songsList.Count)
        {
            songsList.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("There is no song with this number!");
        }

    }

    public void SongFind()
    {
        Console.WriteLine("Enter the song to find: ");
        string input = Console.ReadLine();
        if (songsList.Contains(input))
        {
            Console.WriteLine("The song is in your playlist");
        }
        else
        {
            Console.WriteLine("There's no song in the playlist");
        }
    }

    public void AllSongs()
    {
        int number = 1;
        foreach (string song in songsList)
        {
            Console.WriteLine($"{number}. {song}");
            number++;
        }
    }

}