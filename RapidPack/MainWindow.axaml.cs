using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using AvaloniaApplication1.Classes;

namespace RapidPack;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    ParcelCalculator parcelCalculator = new ParcelCalculator();
    private void HandleCalculation(object? sender, RoutedEventArgs e)
    {
        TextBox[] textBoxes = [HeightBox, WidthBox, DepthBox, WeightBox];
        TextBlock output = this.output;
        
        if (textBoxes.All(x => int.TryParse(x.Text, out int result)))
        {
            int parcelHeight = int.Parse(HeightBox.Text);
            int parcelWidth = int.Parse(WidthBox.Text);
            int parcelDepth = int.Parse(DepthBox.Text);
            int parcelWeight = int.Parse(WeightBox.Text);
            bool expressChecked = ExpressBox.IsChecked ?? false;
            int deliveryChoice = DeliveryBox.SelectedIndex;

            if (parcelWeight <= 30)
            {
                int parcelPrice = parcelCalculator.CalculatePrice(parcelWidth, parcelHeight, parcelDepth, parcelWeight,expressChecked, deliveryChoice);
                output.Foreground = new SolidColorBrush(Colors.Black);
                output.Text = parcelPrice.ToString();
            }
            else
            {
                output.Foreground = new SolidColorBrush(Colors.Red);
                output.Text = "Waga przesyłki jest zbyt duża!";
            }
        }
        else
        {
            output.Foreground = new SolidColorBrush(Colors.Red);
            output.Text = "Podano nieprawidłowe/niepełne dane!";
        }
    }
    
}