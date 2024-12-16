using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";
    
    [ObservableProperty]
    private string _textBlockName = "Welcome to Piyush's Avalonia app!";

    // public string TextBlockName
    // {
    //     get => _textBlockName;
    //     set
    //     {
    //         _textBlockName = value;
    //         OnPropertyChanged();
    //     }
    // }
    
    [RelayCommand] // Optional, if used public method can be marked as private.
    // When calling the method on AXAML file, add Command as suffix of method
    private void ButtonOnClick()
    {
        TextBlockName = "CLICKED!";
    }
}