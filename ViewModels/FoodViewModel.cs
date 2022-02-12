using Microsoft.Toolkit.Mvvm.ComponentModel;
using MvvmDemo.Models;

namespace MvvmDemo.ViewModels;

public class FoodViewModel : ObservableObject
{
    private readonly Food _food;

    private string _name;
    private string _comment = string.Empty;

    public FoodViewModel(Food food)
    {
        _food = food;

        _name = food.Name;
    }

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public string Comment
    {
        get => _comment;
        set => SetProperty(ref _comment, value);
    }

    public int KiloCalories => _food.KiloCalories;
    public int Fat => _food.Fat;
    public int Protein => _food.Protein;
    public int Carbs => _food.Carbs;
}