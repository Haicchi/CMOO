namespace LB_6._1;

public class WildAnimals
{
    protected string nameAnimal;


    protected int ageAnimal;


    protected int weightAnimal;
    
    protected string whereCanBe;

    public string NameAnimal
    {
        get { return nameAnimal; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Project name animal must be empty");
            }
            nameAnimal = value;
        }
    }

    public int AgeAnimal
    {
        get { return ageAnimal; }
        set
        {
            if (!int.TryParse(value.ToString(), out int parsed))
            {
                throw new ArgumentException("Project age animal must be an integer");
            }
            ageAnimal = parsed;
        }
    }

    public double WeightAnimal
    
    {get { return weightAnimal; }
        set
        {
            if (!int.TryParse(value.ToString(), out int parsed2))
            {
                throw new ArgumentException("Project age animal must be an integer");
            }
            weightAnimal = parsed2;
        }
        
    }
    public string WhereCanBe
    {
        get { return whereCanBe; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Project name must not be empty");
            }
            whereCanBe = value;
        }
    }
    

    public WildAnimals(string nameAnimal, int ageAnimal, int weightAnimal,string whereCanBe)
    {
        this.nameAnimal = nameAnimal;
        this.ageAnimal = ageAnimal;
        this.weightAnimal = weightAnimal;
        this.whereCanBe = whereCanBe;
    }

    public WildAnimals()
    {
        nameAnimal = "";
        ageAnimal = 0;
        weightAnimal = 0;
        whereCanBe = "";
    }

    public virtual string AnimalType()
    {
        return "Wild animal type";
    }

    public override string ToString()
    {
        return $"Animal: {nameAnimal}, Age: {ageAnimal}, Weight: {weightAnimal}, WhereCanBe: {whereCanBe}"; 
    }
}
    
    
