using System.Threading.Channels;

namespace LB_6._1;

public class PredatoryAnimals : WildAnimals
{
    
    private double avgCountOfAnimals;
    private double rateOfChange;

    public PredatoryAnimals(string nameAnimal, int ageAnimal, int weightAnimal,string whereCanBe, double avgCountOfAnimals, double rateOfChange) : base(nameAnimal, ageAnimal, weightAnimal, whereCanBe)
    {
       
        this.avgCountOfAnimals = avgCountOfAnimals;
        this.rateOfChange = rateOfChange;
    }

    public PredatoryAnimals():base()
    {
        
        avgCountOfAnimals = 0;
        rateOfChange = 0.0;
    }

    

    public double AvgCountOfAnimals
    {
        get { return avgCountOfAnimals; }
        set{ if (!double.TryParse(value.ToString(), out double parsed2))
            {
                throw new ArgumentException("Project age animal must be an integer");
            }
            avgCountOfAnimals = parsed2;
        }
    }

    public double RateOfChange
    {
        get { return rateOfChange; }
        set{if (!double.TryParse(value.ToString(), out double parsed2))
            {
                throw new ArgumentException("Project age animal must be an integer");
            }
            rateOfChange = parsed2;
        }
    }

    public void IsFine()
    {
        if (rateOfChange <= 1){
            Console.WriteLine($"{rateOfChange}<=1.So population is in danger");
        }
        else
        {
            Console.WriteLine($"{rateOfChange}>1.So population is fine");
        }
    }

    public override void AnimalType()
    {
        Console.WriteLine("Predatory animal type");
    }
    public override string ToString()
    {
        return base.ToString()+$" Average Count: {avgCountOfAnimals} RateOfChange: {rateOfChange}";
    }
}