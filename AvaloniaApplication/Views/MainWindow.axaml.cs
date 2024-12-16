using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }
    
    public void ButtonOnClick(object? sender, RoutedEventArgs e)
    {
        TextBlockName.Text = "CLICKED!";
    }
}