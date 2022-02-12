namespace MvvmDemo.Models;

public class Food : IBasicNutrients
{
    public Food(string name, int kiloCalories, int fat, int protein, int carbs)
    {
        KiloCalories = kiloCalories;
        Fat = fat;
        Protein = protein;
        Carbs = carbs;
        Name = name;
    }

    public string Name { get; set;  }

    public int KiloCalories { get; }
    public int Fat { get; }
    public int Protein { get; }
    public int Carbs { get; }
}