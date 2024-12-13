using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication.Views;

public partial class TestPanel : Window
{
    public TestPanel()
    {
        InitializeComponent();
    }

    private void ButtonClicked(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("ButtonClicked");
        BlockText.Text = "Text modified!";
    }
}