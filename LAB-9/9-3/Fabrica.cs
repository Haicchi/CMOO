using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Channels;

namespace _9_3;

public static class Fabrica
{
    private static Song[] songs;

    static Fabrica()
    {
        songs = new Song[0];
    }
    
    public static void Show(){

        for (int i = 0; i < songs.Length; i++)
        {
            Console.WriteLine(songs[i].ToString());
        }
    }


public static void AddSong(Song song)
    {
        Array.Resize(ref songs, songs.Length + 1);
        songs[songs.Length - 1] = song;
    }
    public static void Delete(Song song)
    {
        Song[] temp = new Song[songs.Length - 1];
        int index = Array.IndexOf(songs, song);
        if (index < 0 )
        {
            Console.WriteLine("Cannot delete null element");
        
        }
        
        for (int i = 0,j=0; i < songs.Length; i++)
        {
            if (i != index)
            {
                temp[j] = songs[i];
                j++;
            }
        }
        
        songs = temp;
        
        
    }

    public static void SearhByYear(int year)
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

    public static void SearchByAuthor(string author)
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

    public static void SearchByVikonavec(string vikonavec)
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

    public static async Task SaveintoFile(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Create))
        {
            await JsonSerializer.SerializeAsync(fs, songs);
            Console.WriteLine("soxraneno");
        }
    }
    
    public static void DownloadFromFile(string filename)
    {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                if (!File.Exists(filename))
                {
                    Console.WriteLine($"File {filename} does not exist");
                }
                else
                {
                    songs = JsonSerializer.Deserialize<Song[]>(fs);
                    Console.WriteLine("downloaded");
                }
            }
        
       
        
    }

    public static void ShowTextOfSong(Song song)
    {
        Console.WriteLine($"Text of {song.SongName}");
        string path = song.Text;
        Console.WriteLine(path);

        using (StreamReader sr = new StreamReader(path))
        {
            string text = sr.ReadToEnd();
            Console.WriteLine(text);
        }
    }

}