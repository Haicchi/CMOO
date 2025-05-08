namespace _9_3;

public class Song
{
  private string songName;
  private string songAuthor;
  private string composer;
  private int year;
  private string text;
  private string[] vikonavci;

  public Song(string songName, string songAuthor, string composer, int year, string text,string[] vikonavci)
  {
    this.songName = songName;
    this.songAuthor = songAuthor;
    this.composer = composer;
    this.year = year;
    this.text = text;
    this.vikonavci = vikonavci;
  }

  public Song()
  {
    songName = "";
    songAuthor = "";
    composer = "";
    year = 0;
    text = "";
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
    get{ return text; }
    set
    {
      if (value == null)
      {
        throw new ArgumentNullException("value");
      }
      text = value;
    }
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
    return $"Song name -  {songName} | Song author - {songAuthor} | Composer - {composer}  | Year - {year} | Text - {text} | Vikonavci - {string.Join(",", vikonavci)}";
  }
  
}