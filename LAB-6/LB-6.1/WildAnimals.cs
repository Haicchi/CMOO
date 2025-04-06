namespace LB_6._1;

public class WildAnimals
{
    protected string nameAnimal;


    protected int ageAnimal;


    protected double weightAnimal;

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
            if (!double.TryParse(value.ToString(), out double parsed2))
            {
                throw new ArgumentException("Project age animal must be an integer");
            }
            weightAnimal = parsed2;
        }
        
    }
    

    public WildAnimals(string nameAnimal, int ageAnimal, double weightAnimal)
    {
        this.nameAnimal = nameAnimal;
        this.ageAnimal = ageAnimal;
        this.weightAnimal = weightAnimal;
    }

    public WildAnimals()
    {
        nameAnimal = "";
        ageAnimal = 0;
        weightAnimal = 0.0;
    }

    public override string ToString()
    {
        return $"Animal: {nameAnimal}, Age: {ageAnimal}, Weight: {weightAnimal}"; 
    }
}
    
    
