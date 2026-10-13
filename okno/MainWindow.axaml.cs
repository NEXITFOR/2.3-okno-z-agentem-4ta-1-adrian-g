using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace okno;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnClickMeClick(object? sender, RoutedEventArgs e)
    {
        var color = Color.FromRgb(
            (byte)Random.Shared.Next(256),
            (byte)Random.Shared.Next(256),
            (byte)Random.Shared.Next(256));

        Background = new SolidColorBrush(color);
    }

    private void OnExitClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}
