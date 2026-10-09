// using C__Preply;
// var playlist = new Playlist();
// bool songMenu = true;
//
// while (songMenu)
// {
//     Console.WriteLine("=== PLAYLIST MENU ===");
//     Console.WriteLine("1. Add song");
//     Console.WriteLine("2. Show whole playlist");
//     Console.WriteLine("3. Find song");
//     Console.WriteLine("4. Delete song by name");
//     Console.WriteLine("5. Delete song by number");
//     Console.WriteLine("6. Show the number of songs");
//     Console.WriteLine("7. Finish the programm");
//     Console.Write("\nSelect an option (1-7): ");
//     
//     string choice = Console.ReadLine();
//     
//     switch (choice)
//     {
//         case "1":
//             playlist.AddSong();
//             break;
//         case "2":
//             playlist.AllSongs();
//             break;
//         case "3":
//             playlist.SongFind();
//             break;
//         case "4":
//             playlist.DeleteSongByName();
//             break;
//         case "5":
//             playlist.DeleteSongByIndex();
//             break;
//         case "6":
//             Console.WriteLine($"Total songs: {playlist.SongCount}");
//             break;
//         case "7":
//             Console.WriteLine("The playlist is finished. Good bye!");
//             songMenu = false;
//             break;
//         default:
//             Console.WriteLine("Error! Choose the number from the menu!");
//             Console.WriteLine("\nInvalid option! Please enter 1 - 7");
//             break;
//     }
//     
//  
// }

using C__Preply;

int test = default;
double test2 = default;
string test3 = default;
Playlist test4 = default;
List<string> test5 = new List<string>();

Console.WriteLine(test);
Console.WriteLine(test2);
Console.WriteLine(test3.ToCharArray());
Console.WriteLine(test4.ToString());
Console.WriteLine(test5);