namespace _9_3;

public class Creator
{
    static private Random random = new Random();
    static private string[] songNames = {"Червона рута","Два кольори","Ніч яка місячна"};
    static private string[] songAuthors = {"Володимир Івасюк","Дмитро Павличко","Михайло Старицький"};
    static private string[] composer = {"Микола Лисенко","Олександр Білаш","Володимир Івасюк"};
    static private int[] years = { 2015, 2016, 2017, 2019, 2020};
    // static private string[] texts = {"D:\\C#\\LABS\\LAB-9\\9-3\bin\\Debug\\net9.0\\text1.txt","D:\\C#\\LABS\\LAB-9\\9-3\bin\\Debug\\net9.0\\text2.txt","D:\\C#\\LABS\\LAB-9\\9-3\bin\\Debug\\net9.0\\text3.txt"};
    static private string[] texts = {"text1.txt","text2.txt","text3.txt"};
    static private string[] vikonavci = {"Володимир Івасюк","Назарій Яремчук","Софія Ротару"};

    public static string RandomSongName()
    {
        return songNames[random.Next(0, songNames.Length)];
    }

    public static string RandomComposer()
    {
        return composer[random.Next(0, composer.Length)];
    }

    public static string RandomAuthor()
    {
        return songAuthors[random.Next(0, songAuthors.Length)];
    }

    public static string RandomText()
    {
        return texts[random.Next(0, texts.Length)];
    }

    public static int RandomYear()
    {
        return years[random.Next(0, years.Length)];
    }

    public static string RandomVikonavci()
    {
        return vikonavci[random.Next(0, vikonavci.Length)];
    }

    public static Song RandomSong()
    {
        return new Song(RandomSongName(),RandomAuthor(),RandomComposer(),RandomYear(), RandomText(),new string[]{RandomVikonavci()});
    }
}