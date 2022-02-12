using System.Collections.Generic;
using System.Linq;
using System.Windows;
using MvvmDemo.Models;
using MvvmDemo.ViewModels;

namespace MvvmDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var dummyFoods = new List<Food>
            {
                new Food("Quark", 100, 10, 25, 0),
                new Food("Zucker", 400, 0, 0, 100),
            };

            var dummyFoodsViewModels = dummyFoods.Select(food => new FoodViewModel(food)).ToList();

            ViewModel = new MainWindowsViewModel(dummyFoodsViewModels);

            InitializeComponent();
        }

        public MainWindowsViewModel ViewModel { get; }
    }
}