using Syncfusion.SfSkinManager;
using System.Windows;

namespace SyncFusion_Schedulars;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OpenSchedularClick(object sender, RoutedEventArgs e)
    {
        Schedular_Window schedularWindow = new();

        schedularWindow.Owner = this;
        schedularWindow.ShowDialog();
    }

    private void Button_OpenTimeSelectorClick(object sender, RoutedEventArgs e)
    {
        TimeSelector_Window timeWindow = new();

        timeWindow.Owner = this;
        timeWindow.ShowDialog();
    }
}