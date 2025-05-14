namespace _9_3;

public class Song
{
  private string songName;
  private string songAuthor;
  private string composer;
  private int year;
  private string pathtotext;
  private string[] vikonavci;

  public Song(string songName, string songAuthor, string composer, int year, string pathtotext,string[] vikonavci)
  {
    this.songName = songName;
    this.songAuthor = songAuthor;
    this.composer = composer;
    this.year = year;
    this.pathtotext = pathtotext;
    this.vikonavci = vikonavci;
  }

  public Song()
  {
    songName = "";
    songAuthor = "";
    composer = "";
    year = 0;
    pathtotext = "";
    vikonavci = new string[0];
  }

  public string SongName
  {
     get{ return songName; }
     set
     {
       if (value == null)
       {
         throw new ArgumentNullException("value");
       }
       songName = value;
     }
  }

  public string SongAuthor
  {
    get{ return songAuthor; }
    set
    {
      if (value == null)
      {
        throw new ArgumentNullException("value");
      }
      songAuthor = value;
    }
  }

  public string Composer
  {
    get{ return composer; }
    set
    {
      if (value == null)
      {
        throw new ArgumentNullException("value");
      }
      composer = value;
    }
  }

  public int Year
  {
    get{ return year; }
    set
    {
      if (!int.TryParse(value.ToString(), out int parsedYear))
      {
        throw new ArgumentOutOfRangeException("value");
      }
      year = parsedYear;
    }
  }

  public string Text
  {
    get{ return pathtotext; }
    // set
    // {
    //   if (value == null)
    //   {
    //     throw new ArgumentNullException("value");
    //   }
    //   pathtotext = value;
    // }
  }

  public string[] Vikonavci
  {
    get{ return vikonavci; }
    set
    {
      if (value == null)
      {
        throw new ArgumentNullException("value");
      }
      vikonavci = value;
    }
  }

  public void ForVikonavci()
  {
    for (int i = 0; i < vikonavci.Length; i++)
    {
      Console.WriteLine(vikonavci[i]);
    }
  }
  public override string ToString()
  {
    return $"Song name -  {songName} | Song author - {songAuthor} | Composer - {composer}  | Year - {year} | Vikonavci - {string.Join(",", vikonavci)}";
  }
  
}