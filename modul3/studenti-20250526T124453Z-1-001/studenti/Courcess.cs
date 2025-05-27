namespace studenti;

public class Courcess
{
    private string nameofcourse;
    private int nubmer;
    private int amountofcredits;
    private string naychryk;

    public Courcess()
    {
        nameofcourse = "";
        nubmer = 0;
        amountofcredits = 0;
        naychryk = "";
    }

    public Courcess(string nameofcourse, int nubmer, int amountofcredits,string naychryk)
    {
        this.nameofcourse = nameofcourse;
        this.nubmer = nubmer;
        this.amountofcredits = amountofcredits;
        this.naychryk = naychryk;
    }

    public string CourseName
    {
        get { return nameofcourse; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Course name cannot be null or empty");
            }
            nameofcourse = value;
        }
    }

    public override string ToString()
    {
        return $"Name of cource : {nameofcourse} | Number of couce : {nubmer} | Amount of credit : {amountofcredits} |  Naychryk : {naychryk}";
    }
}