using LyricsNotebook;

List<Song> songs = new List<Song>();

while (true)
{
    Console.Clear();
    Console.WriteLine("== lyrics notebook ==");
    Console.WriteLine("1. Add song");
    Console.WriteLine("2. List songs");
    Console.WriteLine("3. Search");
    Console.WriteLine("4. Delete");
    Console.WriteLine("5. Exit");
    Console.WriteLine("");
    Console.WriteLine("Choose an option: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Clear();
        Console.WriteLine("--add your song--");

        Console.WriteLine("enter song title: ");
        string title = Console.ReadLine();

        Console.WriteLine("enter lyrics: ");
        string lyrics = Console.ReadLine();

        Song newSong = new Song(title, lyrics);

        songs.Add(newSong);

        Console.WriteLine("");
        Console.WriteLine("Song saved: ", title);
        Console.ReadKey();


    }

    else if (choice == "2")
    {
        Console.WriteLine("List songs - comming soon");
        Console.ReadKey();
    }

    else if (choice == "3")
    {
        Console.WriteLine("Search - comming soon");
        Console.ReadKey();
    }

    else if (choice == "4")
    {
        Console.WriteLine("Delete - comming soon");
        Console.ReadKey();
    }

    else if (choice == "5")
    {
        break; 
    }
}

