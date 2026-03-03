using Avalonia.Controls;
using Avalonia.Headless.XUnit;

namespace RapidPack.Tests;

public class MainWindowTests
{

    [AvaloniaFact]
    public void TextBox_ShouldAlertWhenNull()
    {
        var window = new MainWindow();
        var WidthBox = window.FindControl<TextBox>("WidthBox");
        var Output = window.FindControl<TextBlock>("output");
        var button = window.FindControl<Button>("Submit");
        
        WidthBox.Text = null;
        
        Assert.Equal("Podano nieprawidłowe/niepełne dane!",Output.Text);
    }
}