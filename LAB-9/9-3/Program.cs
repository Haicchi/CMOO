namespace _9_3;

class Program
{
    static void Main(string[] args)
    {
        Song song1 = Creator.RandomSong();
        Song song2 = Creator.RandomSong();
        Song song3 = Creator.RandomSong();
        Song song4 = Creator.RandomSong();
        Song[] songs = { song1, song2, song3 };
        // Fabrica.Show(ref songs);
        // Fabrica.AddSong(ref songs,song4);
        // Console.WriteLine("DMADMAIO");
        // Fabrica.Show(ref songs);
        // Fabrica.Delete(ref songs,song4);
        // Console.WriteLine("ABOBA");
        // Fabrica.Show(ref songs);
        // string author = "Володимир Івасюк";
        // string vikonavec = "Назарій Яремчук";
        // Fabrica.SearchByAuthor(ref songs,author);
        // Fabrica.SearchByVikonavec(ref songs,vikonavec);
        string path = @"D:\C#\LABS\t9.txt";
        string path2 = @"D:\C#\LABS\t10.txt";
        Fabrica.SaveintoFle(ref songs,path);
        Song[] songs2 =  null;
        Fabrica.DownloadFromFile(path2,out songs2);
       Fabrica.Show(ref songs2);
    }
     

    
     

   
}