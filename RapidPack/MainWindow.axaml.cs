using Avalonia.Controls;

namespace RapidPack;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    /*
    ParcelCalculator parcelCalculator = new ParcelCalculator();
    private void HandleCalculation(object? sender, RoutedEventArgs e)
    {
        TextBox[] textBoxes = [HeightBox, WidthBox, DepthBox, WeightBox];
        
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
                Console.WriteLine(parcelPrice);
            }
            else
            {
                Console.WriteLine("Waga przesyłki jest zbyt duża!");
            }
        }
        else
        {
            Console.WriteLine("Not cool!");
        }
    }
    */
}