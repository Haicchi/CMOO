namespace LAB_7_2;

public interface IEngine<T>
{
    int power { get; set; }
    string engineType { get; set; }
    string EngineInfo();

}