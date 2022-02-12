namespace MvvmDemo.Models;

public interface IBasicNutrients
{
    int KiloCalories { get; }
    int Fat { get; }
    int Protein { get; }
    int Carbs { get; }
}