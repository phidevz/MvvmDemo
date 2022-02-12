using System.Collections.Generic;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MvvmDemo.ViewModels;

public class MainWindowsViewModel : ObservableObject
{
    public MainWindowsViewModel(IReadOnlyList<FoodViewModel> foods)
    {
        Foods = foods;
    }

    public IReadOnlyList<FoodViewModel> Foods { get; }
}