using BMICalculator.ViewModels;

namespace BMICalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new BMIViewModel();
    }
}
