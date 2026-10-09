namespace C__Preply;

public class Playlist
{
    private List<string> _songsList = new();
    
    public int SongCount => _songsList.Count;

    public void AddSong()
    {
        Console.Write("Enter the song for the playlist: ");
        var input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input)) Console.WriteLine("Song name can't be empty!");
        else if (_songsList.Contains(input, StringComparer.InvariantCultureIgnoreCase)) Console.WriteLine("This song already exists!");
        else _songsList.Add(input);
    }

    
    //TODO add search to delete by name
    public void DeleteSongByName()
    {
        Console.WriteLine("Enter the song you want to delete from playlist: ");
        var input = Console.ReadLine();
        _songsList.Remove(input);
    }

    public void DeleteSongByIndex()
    {
        Console.WriteLine("Enter the number of the song to delete: ");

        var input = Convert.ToInt32(Console.ReadLine());
        var index = input - 1;
        
        if (index >= 0 && index < _songsList.Count) _songsList.RemoveAt(index);
        else Console.WriteLine("There is no song with this number!");
        

    }

    public void SongFind()
    {
        Console.WriteLine("Enter the song to find: ");
        var input = Console.ReadLine();
        
        if (_songsList.Contains(input, StringComparer.InvariantCultureIgnoreCase)) 
             Console.WriteLine("The song is in your playlist");
        else Console.WriteLine("There's no song in the playlist");


        Console.WriteLine(_songsList.Contains(input, StringComparer.InvariantCultureIgnoreCase)
            ? "The song is in your playlist"
            : "There's no song in the playlist");
    }

    public void AllSongs()
    {
        var number = 1;
        foreach (var song in _songsList)
        {
            Console.WriteLine($"{number}. {song}");
            number++;
        }
    }
}