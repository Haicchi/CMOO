namespace _9_3;

public static class Fabrica
{
    public static void Show(ref Song[] songs){

        for (int i = 0; i < songs.Length; i++)
        {
            Console.WriteLine(songs[i].ToString());
        }
    }


public static void AddSong(ref Song[] songs,Song song)
    {
        Array.Resize(ref songs, songs.Length + 1);
        songs[songs.Length - 1] = song;
    }
    public static void Delete(ref Song []songs,Song song)
    {
        Song[] temp = new Song[songs.Length - 1];
        int index = Array.IndexOf(songs, song);
        if (index == null)
        {
            Console.WriteLine("Cannot delete null element");
        
        }
        
        for (int i = 0; i < songs.Length; i++)
        {
            if (i != index)
            {
                temp[i] = songs[i];
                
            }
        }
        
        songs = temp;
        
        
    }

    public static void SearhByYear(ref Song[] songs, int year)
    {
        for (int i = 0; i < songs.Length; i++)
        {
            if (songs[i].Year == year)
            {
                Console.WriteLine($"Song that was created in {year} year - {songs[i].SongName}");
                Console.WriteLine("full info");
                Console.WriteLine($"{songs[i].ToString()}");
            }
        }
    }

    public static void SearchByAuthor(ref Song[] songs, string author)
    {
        for (int i = 0; i < songs.Length; i++)
        {
            if (songs[i].SongAuthor == author)
            {
                Console.WriteLine($"Song with that author - {songs[i].SongName}");
                Console.WriteLine("full info");
                Console.WriteLine($"{songs[i].ToString()}");
            }
        }
    }

    public static void SearchByVikonavec(ref Song[] songs, string vikonavec)
    {
        for (int i = 0; i < songs.Length; i++)
        {
            if (vikonavec.Contains(string.Join(',', songs[i].Vikonavci)))
            {
                Console.WriteLine($"Song with that vikonavci - {songs[i].SongName}");
                Console.WriteLine("full info");
                Console.WriteLine($"{songs[i].ToString()}");
            }
        }
    }

    public static void SaveintoFle(ref Song[] songs, string path)
    {
        FileInfo file = new FileInfo(path);
        if (!file.Exists)
        {
            Console.WriteLine("File not found");
            return ;
        }

        for (int i = 0; i < songs.Length; i++)
        {
            File.AppendAllText(path, songs[i].ToString());
            File.AppendAllText(path, Environment.NewLine);
        }
        
    }

    public static void Download(ref Song[] songs, string path)
    {
        FileInfo file = new FileInfo(path);
        if (!file.Exists)
        {
            Console.WriteLine("File not found");
            return ;
        }
        string text = File.ReadAllText(path);
        Song[] temp = new Song[text.Length];
        string[] lines = text.Split($"{Environment.NewLine}");
        for (int i = 0; i < temp.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            temp[i].SongName = parts[0].Trim();
            temp[i].SongAuthor = parts[1].Trim();
            temp[i].Composer = parts[2].Trim();
            temp[i].Year = int.Parse(parts[3].Trim());
            temp[i].Text = parts[4].Trim();
            temp[i].Vikonavci = parts[5].Trim().Split(',');
        }
        songs = temp;
    }

    public static void DownloadFromFile(string path, out Song[] songs)
    {
        songs = null;

        if (!File.Exists(path))
        {
            Console.WriteLine("no file");
            return;
        }

        
        var lines = File.ReadAllLines(path);
        Song[] temp = new Song[lines.Length];
        int count = 0;

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length != 6) continue;

            string name = parts[0].Replace("Song name -", "").Trim();
            string author = parts[1].Replace("Song author -", "").Trim();
            string composer = parts[2].Replace("Composer -", "").Trim();
            string yearStr = parts[3].Replace("Year -", "").Trim();
            string text = parts[4].Replace("Text -", "").Trim();
            string[] performers = parts[5].Replace("Vikonavci -", "").Trim().Split(',', StringSplitOptions.RemoveEmptyEntries);

            int year = int.TryParse(yearStr, out int y) ? y : 0;

            temp[count] = new Song(name, author, composer, year, text, performers);
            count++;
        }
        songs = new Song[count];
        Array.Copy(temp, songs, count);

        Console.WriteLine($"Downloaded {songs.Length}.");
      
    }

}