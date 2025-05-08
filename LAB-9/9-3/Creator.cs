namespace _9_3;

public class Creator
{
    static private Random random = new Random();
    static private string[] songNames = {"Червона рута","Два кольори","Ніч яка місячна"};
    static private string[] songAuthors = {"Володимир Івасюк","Дмитро Павличко","Михайло Старицький"};
    static private string[] composer = {"Микола Лисенко","Олександр Білаш","Володимир Івасюк"};
    static private int[] years = { 2015, 2016, 2017, 2019, 2020};
    static private string[] texts = {"Ти признайся мені, звідки в тебе ті чари," + "\nЯ без тебе всі дні у полоні печалі." + "\nМоже десь у лісах ти чаклуєш ночами," + "\nМожеш зілля якесь вариш ти під дубами." + "","Як я був молодий, у похід вирушав," + "\nМене мати старенька в дорогу пускала." + "\nДала мені вишитий рушник на плечі," + "\nІ сказала: \"Вертайся, синочку, скоріше\"." + "","Ніч яка місячна, зоряна, ясная,\n" + "Видно, хоч голки збирай.\nВийди, коханая," + " працею зморена,\nХоч на хвилиночку в гай." };
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