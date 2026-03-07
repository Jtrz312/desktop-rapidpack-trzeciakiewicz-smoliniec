using Avalonia.Controls;
using Avalonia.Headless.XUnit;
using Avalonia.Interactivity;

namespace RapidPack.Tests;

public class MainWindowTests
{

    [AvaloniaFact]
    public void TextBox_ShouldAlertWhenNullOrInvalid()
    {
        var window = new MainWindow();
        var WidthBox = window.FindControl<TextBox>("WidthBox");
        var HeightBox = window.FindControl<TextBox>("HeightBox");
        var DepthBox = window.FindControl<TextBox>("DepthBox");
        var WeightBox = window.FindControl<TextBox>("WeightBox");
        
        var Output = window.FindControl<TextBlock>("output");
        var button = window.FindControl<Button>("Submit");
        
        WidthBox.Text = null;
        HeightBox.Text = "Co tu robi string";
        DepthBox.Text = "";
        WeightBox.Text = "16";
        
        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        
        Assert.Equal("Podano nieprawidłowe/niepełne dane!",Output.Text);
    }
    
    // success
    
    [AvaloniaFact]
    public void WeightBox_ShouldAlertWhenOver30()
    {
        var window = new MainWindow();
        var WidthBox = window.FindControl<TextBox>("WidthBox");
        var HeightBox = window.FindControl<TextBox>("HeightBox");
        var DepthBox = window.FindControl<TextBox>("DepthBox");
        var WeightBox = window.FindControl<TextBox>("WeightBox");
        
        var Output = window.FindControl<TextBlock>("output");
        var button = window.FindControl<Button>("Submit");
        
        WidthBox.Text = "15";
        HeightBox.Text = "32";
        DepthBox.Text = "53";
        WeightBox.Text = "31";
        
        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        
        Assert.Equal("Waga przesyłki jest zbyt duża!",Output.Text);
    }
    //success
    
    [AvaloniaFact]
    public void Express_WhenChecked_ShouldAdd15ToPrice()
    {
        var window = new MainWindow();
        var WidthBox = window.FindControl<TextBox>("WidthBox");
        var HeightBox = window.FindControl<TextBox>("HeightBox");
        var DepthBox = window.FindControl<TextBox>("DepthBox");
        var WeightBox = window.FindControl<TextBox>("WeightBox");
        var ExpressBox = window.FindControl<CheckBox>("ExpressBox");
        
        var Output = window.FindControl<TextBlock>("output");
        var button = window.FindControl<Button>("Submit");
        
        WidthBox.Text = "15";
        HeightBox.Text = "32";
        DepthBox.Text = "53";
        WeightBox.Text = "1";
        ExpressBox.IsChecked = true;
        
        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        
        Assert.Equal("27",Output.Text);
    }
    
    //success
    
    [AvaloniaFact]
    public void DeliveryOption_WhenChanged_ShouldIncreasePrice()
    {
        var window = new MainWindow();
        var WidthBox = window.FindControl<TextBox>("WidthBox");
        var HeightBox = window.FindControl<TextBox>("HeightBox");
        var DepthBox = window.FindControl<TextBox>("DepthBox");
        var WeightBox = window.FindControl<TextBox>("WeightBox");
        var DeliveryBox = window.FindControl<ComboBox>("DeliveryBox");
        var ExpressBox = window.FindControl<CheckBox>("ExpressBox");

        var Output = window.FindControl<TextBlock>("output");
        var button = window.FindControl<Button>("Submit");
        
        WidthBox.Text = "15";
        HeightBox.Text = "32";
        DepthBox.Text = "53";
        WeightBox.Text = "1";
        ExpressBox.IsChecked = true;
        DeliveryBox.SelectedIndex = 1;
        
        button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        var OutputTextToNum = int.Parse(Output.Text);
        Assert.Equal(true,OutputTextToNum > 27);
    }
    //success
}