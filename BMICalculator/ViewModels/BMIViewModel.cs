using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.ViewModels;

public partial class BMIViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsMaleSelected))]
    [NotifyPropertyChangedFor(nameof(IsFemaleSelected))]
    private string? _selectedGender = "Male";

    public bool IsMaleSelected => SelectedGender == "Male";
    public bool IsFemaleSelected => SelectedGender == "Female";

    [RelayCommand]
    public void SelectGender(string gender)
    {
        SelectedGender = gender; 
    }
}
